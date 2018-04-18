using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventaris
{
    public partial class UCDataRuangan : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;
        int no, id;
        string nama;
        UCRuangan ucRuangan;

        public UCDataRuangan(UCRuangan ucRuangan, int no, int id, string nama)
        {
            InitializeComponent();
            this.no = no;
            this.id = id;
            this.nama = nama;
            this.ucRuangan = ucRuangan;
            
            setData();
        }

        private void setData()
        {
            lblNo.Text = no + ".";
            lblID.Text = id.ToString();
            lblNama.Text = nama;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormTambahRuangan tambahRuangan = new FormTambahRuangan(ucRuangan, true, id);
            tambahRuangan.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MySqlCommand query = new MySqlCommand("DELETE FROM ruangan WHERE id = '" + id + "'", conn);
                conn.Open();
                query.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Berhasil!");
                ucRuangan.fillFlow();
            }
        }
    }
}