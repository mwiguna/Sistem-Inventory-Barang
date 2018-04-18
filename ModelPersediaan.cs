using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inventaris
{
    class ModelPersediaan
    {
        MySqlConnection conn;
        UCPersediaan ucPersediaan;

        int[] label;
        string[] atribut = new string[] { };
        static string data1, data2, data3, data4, data5, data6, query;
        static MySqlCommand cmd;
        static MySqlDataReader reader;

        public ModelPersediaan(MySqlConnection conn, UCPersediaan ucPersediaan)
        {
            this.conn = conn;
            this.ucPersediaan = ucPersediaan;
        }

        public void semuaSatuan(string tipe = null, string ruang = null, int kondisi = 2, string search = null)
        {
            string optional = "";
            if (tipe != null) optional   += " AND barang.tipe       = '" + tipe + "' ";
            if (ruang != null) optional  += " AND satuan.id_ruangan = '" + ruang + "' ";
            if (kondisi != 2) optional   += " AND satuan.kondisi    = '" + kondisi + "' ";
            if (search != "") optional   += " AND barang.nama LIKE '%" + search + "%' ";

            query = "SELECT satuan.id AS id, satuan.kondisi AS kondisi, barang.nama AS nama, jenis_barang.nama AS jenis, ruangan.nama AS ruangan FROM satuan, barang, jenis_barang, ruangan, riwayat WHERE barang.id = satuan.id_barang AND jenis_barang.id = barang.tipe AND ruangan.id = satuan.id_ruangan AND satuan.id = riwayat.id_satuan AND riwayat.jenis = 1 AND riwayat.verifikasi = 1 AND satuan.ketersediaan = 1 " + optional + " ORDER BY satuan.id DESC";
            label = new int[] { 6 };
            setData("id", "nama", "jenis", "ruangan", "kondisi", null, label, "semuaBarangMasuk");
            atribut = new string[] { "id", "nama", "jenis", "ruangan", "kondisi" };
        }

        public void semuaJenis(string ruang = null, int kondisi = 2, string search = null)
        {
            string optional = "";
            string qSearch  = "";
            if (ruang != null) optional  += " AND satuan.id_ruangan = '" + ruang + "' ";
            if (kondisi != 2) optional   += " AND satuan.kondisi    = '" + kondisi + "' ";
            if (search != "") qSearch     = " WHERE barang.nama LIKE '%" + search + "%' ";

            query = "SELECT barang.id AS id, barang.nama AS nama, jenis_barang.nama AS tipe, COUNT(satuan.id_barang) AS jumlah FROM barang LEFT JOIN (SELECT satuan.id, satuan.id_barang AS id_barang FROM satuan JOIN riwayat ON satuan.id = riwayat.id_satuan AND riwayat.verifikasi = 1 AND satuan.ketersediaan = 1 " + optional + ") AS satuan ON satuan.id_barang = barang.id LEFT JOIN jenis_barang ON jenis_barang.id = barang.tipe " + qSearch + " GROUP BY satuan.id_barang, barang.id ORDER BY id DESC";
            label = new int[] { 4, 5 };
            setData("id", "nama", "tipe", null, null, "jumlah", label, "semuaDataBarang");
            atribut = new string[] { "id", "nama", "tipe", "jumlah" };
        }

        public void semuaTipe(string ruang = null, int kondisi = 2, string search = null)
        {
            string optional = "";
            string qSearch  = "";
            if (ruang != null) optional  += " AND satuan.id_ruangan = '" + ruang + "' ";
            if (kondisi != 2) optional   += " AND satuan.kondisi    = '" + kondisi + "' ";
            if (search != "") qSearch     = " WHERE jenis_barang.nama LIKE '%" + search + "%' ";

            query = "SELECT jenis_barang.nama AS tipe, COUNT(satuan.id) AS jumlah FROM jenis_barang LEFT JOIN barang ON barang.tipe = jenis_barang.id LEFT JOIN (SELECT satuan.id AS id, satuan.id_barang AS id_barang FROM satuan, riwayat WHERE satuan.id = riwayat.id_satuan AND riwayat.verifikasi = 1 AND satuan.ketersediaan = 1 " + optional + ") AS satuan ON satuan.id_barang = barang.id " + qSearch + " GROUP BY jenis_barang.nama";
            label = new int[] { 1, 2, 4, 5 };
            setData(null, null, "tipe", null, null, "jumlah", label, null);
            atribut = new string[] { "tipe", "jumlah" };
        }

        // Set Data

        private void setData(string pdata1, string pdata2, string pdata3, string pdata4, string pdata5, string pdata6, int[] label, string tipe)
        {
            conn.Open();
            cmd = new MySqlCommand(query, conn);

            // Data Items For DataGrid
            UCPersediaan.data = new DataTable();
            UCPersediaan.data.Columns.Add("No.", typeof(int));

            // Set Atribut
            int j = 0;
            foreach (string item in atribut)
            {
                UCPersediaan.data.Columns.Add(atribut[j].ToUpper(), typeof(string));
                j++;
            }

            reader = cmd.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                data1 = (pdata1 != null) ? Convert.ToString(reader[pdata1]) : null;
                data2 = (pdata2 != null) ? Convert.ToString(reader[pdata2]) : null;
                data3 = (pdata3 != null) ? Convert.ToString(reader[pdata3]) : null;
                data4 = (pdata4 != null) ? Convert.ToString(reader[pdata4]) : null;
                data5 = (pdata5 != null) ? ( (pdata5 == "kondisi") ? convertKondisi(Convert.ToString(reader[pdata5])) : Convert.ToString(reader[pdata5]) ) : null;      
                data6 = (pdata6 != null) ? Convert.ToString(reader[pdata6]) : null;

                UCDataPersediaan ucData = new UCDataPersediaan(ucPersediaan, i, data1, data2, data3, data4, data5, data6, tipe);

                foreach(int index in label)
                {
                    Label lbl = ucData.Controls.Find("lbl"+index, true).FirstOrDefault() as Label;
                    lbl.Visible = false;
                }

                // DataGrid
                string[] adata = new string[] { data1, data2, data3, data4, data5, data6 };
                ArrayList value = new ArrayList();

                value.Add(i);
                foreach (string item in adata)
                {
                    if (item != null) value.Add(item);
                }

                try
                {
                    UCPersediaan.data.Rows.Add(value.ToArray());
                }
                catch (ArgumentException ex) {}

                ucPersediaan.flowLayoutPanel.Controls.Add(ucData);
                i++;
            }
            
            conn.Close();
        }

        // Public

        public static string convertKondisi(string param)
        {
            string iKondisi = param;
            string kondisi;

            if (iKondisi == "1") kondisi = "Baik";
            else kondisi = "Rusak";
            return kondisi;
        }

    }
}