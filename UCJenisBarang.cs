using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Inventaris
{
    public partial class UCJenisBarang : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;

        public UCJenisBarang()
        {
            InitializeComponent();
            fillFlow();
        }

        public void fillFlow()
        {
            flowLayoutPanel.Controls.Clear();
            MySqlCommand query = new MySqlCommand("SELECT * FROM jenis_barang", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string nama = Convert.ToString(reader["nama"]);

                UCDataJenisBarang ucData = new UCDataJenisBarang(this, i, id, nama);
                flowLayoutPanel.Controls.Add(ucData);
                i++;
            }

            conn.Close();
        }

        public static void setTipeBarang(MySqlConnection conn, ComboBox comboBox)
        {
            MySqlCommand query = new MySqlCommand("SELECT * FROM jenis_barang", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            List<Object> items = new List<Object>();
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string nama = Convert.ToString(reader["nama"]);

                items.Add(new { Text = nama, Value = id });
            }

            comboBox.DataSource = items;
            comboBox.SelectedIndex = 0;
            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahJenisBarang jenisBarang = new FormTambahJenisBarang(this, false);
            jenisBarang.Show();
        }
    }
}