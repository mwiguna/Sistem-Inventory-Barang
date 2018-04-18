using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventaris
{
    public partial class UCDataRiwayat : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;
        MySqlCommand query;
        int no, id, id_satuan, verifikasi, ketersediaan;
        UCRiwayat ucRiwayat;

        string nama, jenis, tanggal;

        public UCDataRiwayat(UCRiwayat ucRiwayat, int no, int id, int id_satuan, string nama, int jenis, string tanggal, int verifikasi)
        {
            InitializeComponent();

            this.no = no;
            this.id = id;
            this.id_satuan = id_satuan;
            this.nama = nama;
            this.tanggal = tanggal;
            this.ucRiwayat = ucRiwayat;

            if (jenis == 0) this.jenis = "Keluar";
            else this.jenis = "Masuk";

            if (verifikasi == 1) checkBox.Checked = true;
            setData();
        }

        private void setData()
        {
            tbNo.Text = no + ".";
            tbID.Text = id_satuan.ToString();
            tbNama.Text = nama;
            tbJenis.Text = jenis;
            tbTanggal.Text = tanggal;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ModelDatabase.createdDone)
            {
                if (checkBox.Checked)
                {
                    verifikasi = 1;
                    ketersediaan = 0;
                }
                else
                {
                    verifikasi = 0;
                    ketersediaan = 1;
                }
                query = new MySqlCommand("UPDATE riwayat SET verifikasi = '"+ verifikasi +"' WHERE id = '" + id + "'", conn);
                execute();

                if(jenis == "Keluar")
                {
                    query = new MySqlCommand("UPDATE satuan SET ketersediaan = '"+ ketersediaan +"' WHERE id = '" + id_satuan + "'", conn);
                    execute();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if(jenis == "Masuk") query = new MySqlCommand("DELETE FROM satuan WHERE id = '" + id_satuan + "'", conn);
                else query = new MySqlCommand("DELETE FROM riwayat WHERE id = '" + id + "'", conn);
                  
                execute();
                MessageBox.Show("Berhasil");
                ucRiwayat.fillFlow();
            }
        }

        private void execute()
        {
            try
            {
                conn.Open();
                query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

    }
}