using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventaris
{
    public partial class UCUser : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;

        public UCUser()
        {
            InitializeComponent();
            fillFlow();
        }

        public void fillFlow()
        {
            flowLayoutPanel.Controls.Clear();
            MySqlCommand query = new MySqlCommand("SELECT * FROM user", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                int id      = Convert.ToInt32(reader["id"]);
                string nip  = Convert.ToString(reader["nip"]);
                string nama = Convert.ToString(reader["nama"]);
                int role    = Convert.ToInt32(reader["role"]);

                UCDataUser ucData = new UCDataUser(this, i, id, nip, nama, role);
                flowLayoutPanel.Controls.Add(ucData);
                i++;
            }

            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahUser tambahUser = new FormTambahUser(this, false);
            tambahUser.Show();
        }
    }
}