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
    public partial class UCRiwayat : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;

        public UCRiwayat()
        {
            InitializeComponent();
            fillFlow();
        }

        public void fillFlow()
        {
            ModelDatabase.createdDone = false;
            flowLayoutPanel.Controls.Clear();

            String query = "SELECT riwayat.*, barang.nama AS nama, satuan.id AS id_satuan FROM riwayat, satuan, barang WHERE satuan.id = riwayat.id_satuan AND barang.id = satuan.id_barang ORDER BY riwayat.id DESC";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {

                int id = Convert.ToInt32(reader["id"]);
                int id_satuan  = Convert.ToInt32(reader["id_satuan"]);
                String nama    = Convert.ToString(reader["nama"]);
                String tanggal = Convert.ToDateTime(reader.GetDateTime(reader.GetOrdinal("tanggal"))).ToString("dd-MM-yyyy");
                int jenis      = Convert.ToInt16(reader["jenis"]);
                int verifikasi = Convert.ToInt16(reader["verifikasi"]);

                UCDataRiwayat ucData = new UCDataRiwayat(this, i, id, id_satuan, nama, jenis, tanggal, verifikasi);
                flowLayoutPanel.Controls.Add(ucData);
                i++;
            }
            
            conn.Close();
            ModelDatabase.createdDone = true;
        }
    }
}