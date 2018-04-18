using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormTambahDataBarang : Form
    {
        MySqlConnection conn = ModelDatabase.conn;
        UCPersediaan ucPersediaan;
        int id;

        public FormTambahDataBarang(UCPersediaan ucPersediaan, Boolean edit, int id = 0)
        {
            InitializeComponent();
            this.ucPersediaan = ucPersediaan;
            this.id = id;

            if (edit)
            {
                btnTambah.Visible = false;
                setDataEdit();
            }
            else btnEdit.Visible = false;
            UCJenisBarang.setTipeBarang(conn, cbTipe);
        }

        private void setDataEdit()
        {
            MySqlCommand query = new MySqlCommand("SELECT * FROM barang WHERE id = '" + id + "'", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                tbNama.Text = Convert.ToString(reader["nama"]);
                cbTipe.SelectedValue = Convert.ToInt32(reader["tipe"]);
            }

            conn.Close();
        }
        

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                MySqlCommand query = new MySqlCommand("INSERT INTO barang (nama, tipe) VALUES ('" + tbNama.Text + "', '" + cbTipe.SelectedValue + "')", conn);
                execute(query);
            }
            else MessageBox.Show("Harap Lengkapi Form");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                MySqlCommand query = new MySqlCommand("UPDATE barang SET nama = '"+ tbNama.Text + "', tipe = '" + cbTipe.SelectedValue + "' WHERE id = '" + id +"'", conn);
                execute(query);
                Close();
            }
            else MessageBox.Show("Harap Lengkapi Form");
        }

        private void execute(MySqlCommand query)
        {
            try
            {
                conn.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            ucPersediaan.fillFlow();
        }
    }
}