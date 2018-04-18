using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventaris
{
    public partial class UCDataJenisBarang : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;
        int no, id;
        string jenis;
        UCJenisBarang ucJenisBarang;

        public UCDataJenisBarang(UCJenisBarang ucJenisBarang, int no, int id, string jenis)
        {
            InitializeComponent();
            this.ucJenisBarang = ucJenisBarang;
            this.no = no;
            this.id = id;
            this.jenis = jenis;

            setData();
        }

        private void setData()
        {
            lblNo.Text    = no + ".";
            lblID.Text    = id.ToString();
            lblJenis.Text = jenis;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormTambahJenisBarang tambahJenisBarang = new FormTambahJenisBarang(ucJenisBarang, true, id);
            tambahJenisBarang.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MySqlCommand query = new MySqlCommand("DELETE FROM jenis_barang WHERE id = '" + id + "'", conn);
                conn.Open();
                query.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Berhasil!");
                ucJenisBarang.fillFlow();
            }
        }
    }
}
