using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class UCDataPersediaan : UserControl
    {
        MySqlConnection conn = ModelDatabase.conn;
        UCPersediaan ucPersediaan;
        String data1, data2, data3, data4, data5, data6, tipe;

        int no;

        public UCDataPersediaan(UCPersediaan ucPersediaan, int no, String data1, String data2, String data3, String data4, String data5, String data6, String tipe)
        {
            InitializeComponent();

            this.no   = no;
            this.data1 = data1;
            this.data2 = data2;
            this.data3 = data3;
            this.data4 = data4;
            this.data5 = data5;
            this.data6 = data6;
            this.tipe = tipe;
            this.ucPersediaan = ucPersediaan;

            if (tipe == "semuaBarangMasuk") btnHapus.Visible = false;
            else if (tipe == "semuaDataBarang") checkBox.Visible = false;
            else flowAksi.Visible = false;

            setData();
        }

        private void setData()
        {
            lblNo.Text = no + ".";
            lbl1.Text = data1;
            lbl2.Text = data2;
            lbl3.Text = data3;
            lbl4.Text = data4;
            lbl5.Text = data5;
            lbl6.Text = data6;
        }

        // Action

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if(tipe == "semuaBarangMasuk")
            {
                FormTambahBarangMasuk barangMasuk = new FormTambahBarangMasuk(ucPersediaan, true, Convert.ToInt32(data1));
                barangMasuk.Show();
            }
            else if(tipe == "semuaDataBarang")
            {
                FormTambahDataBarang dataBarang = new FormTambahDataBarang(ucPersediaan, true, Convert.ToInt32(data1));
                dataBarang.Show();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MySqlCommand query = new MySqlCommand("DELETE FROM barang WHERE id = '" + data1 + "'", conn);
                conn.Open();
                query.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Berhasil!");
                ucPersediaan.fillFlow();
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                UCPersediaan.checkedId.Add(data1);
                UCPersediaan.checkedItem.Add(data2);
            }
            else
            {
                UCPersediaan.checkedId.Remove(data1);
                UCPersediaan.checkedItem.Remove(data2);
            }
        }

    }
}