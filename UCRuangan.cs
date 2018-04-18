using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventaris
{
    public partial class UCRuangan : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;

        public UCRuangan()
        {
            InitializeComponent();
            fillFlow();
        }

        public void fillFlow()
        {
            flowLayoutPanel.Controls.Clear();
            MySqlCommand query = new MySqlCommand("SELECT * FROM ruangan", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string nama = Convert.ToString(reader["nama"]);

                UCDataRuangan ucData = new UCDataRuangan(this, i, id, nama);
                flowLayoutPanel.Controls.Add(ucData);
                i++;
            }

            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahRuangan tambahRuangan = new FormTambahRuangan(this, false);
            tambahRuangan.Show();
        }
    }
}
