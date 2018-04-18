
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class UCDataUser : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;
        int no, id;
        string nip, nama, jabatan;
        UCUser ucUser;

        public UCDataUser(UCUser ucUser, int no, int id, string nip, string nama, int role)
        {
            InitializeComponent();
            this.ucUser = ucUser;

            this.no = no;
            this.id = id;
            this.nip = nip;
            this.nama = nama;

            if (role == 0) jabatan = "Admin";
            else if (role == 1) jabatan = "Manajer";
            else jabatan = "Gudang";

            setData();
        }

        private void setData()
        {
            lblNo.Text = no + ".";
            lblNIP.Text = nip;
            lblNama.Text = nama;
            lblJabatan.Text = jabatan;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormTambahUser tambahUser = new FormTambahUser(ucUser, true, id);
            tambahUser.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MySqlCommand query = new MySqlCommand("DELETE FROM user WHERE id = '" + id + "'", conn);
                conn.Open();
                query.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Berhasil!");
                ucUser.fillFlow();
            }
        }
    }
}