using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormTambahBarangMasuk : Form
    {
        MySqlConnection conn = ModelDatabase.conn;
        MySqlCommand query;
        UCPersediaan ucPersediaan;
        int id;

        public FormTambahBarangMasuk(UCPersediaan ucPersediaan, Boolean edit, int id = 0)
        {
            InitializeComponent();
            UCPersediaan.setKode("barang", cbKode, false);
            UCPersediaan.setKode("ruangan", cbPenggunaan, false);
            this.ucPersediaan = ucPersediaan;
            this.id = id;

            if (edit)
            {
                btnTambah.Visible = false;
                pJumlah.Visible = false;
                pTanggal.Visible = false;
                setKondisi();
                setDataEdit();
            }
            else
            {
                pID.Visible = false;
                pKondisi.Visible = false;
                btnEdit.Visible = false;
            }
        }

        // Set Data

        private void setDataEdit()
        {
            MySqlCommand query = new MySqlCommand("SELECT * FROM satuan WHERE id = '" + id + "'", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                tbID.Text = Convert.ToString(reader["id"]);
                cbKode.SelectedValue = Convert.ToString(reader["id_barang"]);
                cbKondisi.SelectedValue = Convert.ToString(reader["kondisi"]);
                cbPenggunaan.SelectedValue = Convert.ToString(reader["id_ruangan"]);
            }

            conn.Close();
        }

        private void setKondisi()
        {
            List<Object> items = new List<Object>();
            cbKondisi.DisplayMember = "Text";
            cbKondisi.ValueMember   = "Value";

            items.Add(new { Text = "Baik",  Value = "1" });
            items.Add(new { Text = "Rusak", Value = "0" });
            cbKondisi.DataSource = items;
        }

        // Button Action

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbJumlah.Text != "")
            {
                int jumlah = Convert.ToInt32(tbJumlah.Text);

                for (int i = 1; i <= jumlah; i++)
                {
                    // Satuan
                    query = new MySqlCommand("INSERT INTO satuan (id_barang, kondisi, id_ruangan) VALUES ('" + cbKode.SelectedValue + "', '1', '" + cbPenggunaan.SelectedValue + "')", conn);
                    UCPersediaan.execute(query);

                    // Last ID
                    query = new MySqlCommand("SELECT MAX(id) AS id FROM satuan", conn);

                    conn.Open();
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read()){ id = Convert.ToInt16(reader["id"]); }
                    conn.Close();

                    // Riwayat
                    query = new MySqlCommand("INSERT INTO riwayat (id_satuan, tanggal, jenis) VALUES ('" + id + "', '" + UCPersediaan.getTanggal(dateTimePicker) + "', '1')", conn);
                    UCPersediaan.execute(query);
                }

                ucPersediaan.fillFlow();
                MessageBox.Show("Berhasil!");
            }
            else MessageBox.Show("Harap Lengkapi Form");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            query = new MySqlCommand("UPDATE satuan SET id_barang = '"+ cbKode.SelectedValue + "', kondisi = '"+ cbKondisi.SelectedValue + "', id_ruangan = '" + cbPenggunaan.SelectedValue +"' WHERE id = '"+ id +"'", conn);
            UCPersediaan.execute(query);

            MessageBox.Show("Berhasil!");
            Close();
            ucPersediaan.fillFlow();
        }

    }
}