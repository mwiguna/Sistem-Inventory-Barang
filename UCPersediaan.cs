using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;

namespace Inventaris
{
    public partial class UCPersediaan : UserControl
    {
        public static ArrayList checkedId = new ArrayList();
        public static ArrayList checkedItem = new ArrayList();
        public static DataTable data;
        static MySqlConnection conn = ModelDatabase.conn;
        Dictionary<String, Boolean> atribut = new Dictionary<String, Boolean>();
        ModelPersediaan model;
        int kondisi;

        public UCPersediaan()
        {
            InitializeComponent();
            setting();
        }

        // Setting

        private void setting()
        {
            model = new ModelPersediaan(conn, this);

            setKode("jenis_barang", cbTipe, true);
            setKode("ruangan", cbPenggunaan, false);

            radioSatuan.Checked = true;
            fillFlow();
        }

        public void fillFlow()
        {
            flowLayoutPanel.Controls.Clear();

            if (atribut["satuan"])
            {
                resetTitle();
                if (cbTipe.SelectedValue.ToString() == "0")
                {
                    if (atribut["khusus"])
                    {
                        if (atribut["semuaKondisi"]) model.semuaSatuan(null, cbPenggunaan.SelectedValue.ToString(), 2, tbQuery.Text);
                        else model.semuaSatuan(null, cbPenggunaan.SelectedValue.ToString(), kondisi, tbQuery.Text);
                    }
                    else
                    {
                        if (atribut["semuaKondisi"]) model.semuaSatuan(null, null, 2, tbQuery.Text);
                        else model.semuaSatuan(null, null, kondisi, tbQuery.Text);
                    }
                }
                else
                {
                    if (atribut["khusus"])
                    {
                        if (atribut["semuaKondisi"]) model.semuaSatuan(cbTipe.SelectedValue.ToString(), cbPenggunaan.SelectedValue.ToString(), 2, tbQuery.Text);
                        else model.semuaSatuan(cbTipe.SelectedValue.ToString(), cbPenggunaan.SelectedValue.ToString(), kondisi, tbQuery.Text);
                    }
                    else
                    {
                        if (atribut["semuaKondisi"]) model.semuaSatuan(cbTipe.SelectedValue.ToString(), null, 2, tbQuery.Text);
                        else model.semuaSatuan(cbTipe.SelectedValue.ToString(), null, kondisi, tbQuery.Text);
                    }
                }

                btnKeluar.Visible = true;
                btnAturPersediaan.Visible = true;
                title6.Visible = false;
            }
            else if (atribut["jenis"])
            {
                resetTitle();
                if (atribut["khusus"])
                {
                    if (atribut["semuaKondisi"]) model.semuaJenis(cbPenggunaan.SelectedValue.ToString(), 2, tbQuery.Text);
                    else model.semuaJenis(cbPenggunaan.SelectedValue.ToString(), kondisi, tbQuery.Text);
                }
                else
                {
                    if (atribut["semuaKondisi"]) model.semuaJenis(null, 2, tbQuery.Text);
                    else model.semuaJenis(null, kondisi, tbQuery.Text);
                }
                
                btnKeluar.Visible = false;
                btnAturPersediaan.Visible = false;
                title4.Visible = false;
                title5.Visible = false;
            }
            else if (atribut["tipe"])
            {
                resetTitle();
                if (atribut["khusus"])
                {
                    if (atribut["semuaKondisi"]) model.semuaTipe(cbPenggunaan.SelectedValue.ToString(), 2, tbQuery.Text);
                    else model.semuaTipe(cbPenggunaan.SelectedValue.ToString(), kondisi, tbQuery.Text);
                }
                else
                {
                    if (atribut["semuaKondisi"]) model.semuaTipe(null, 2, tbQuery.Text);
                    else model.semuaTipe(null, kondisi, tbQuery.Text);
                }
                
                btnKeluar.Visible = false;
                btnAturPersediaan.Visible = false;
                title1.Visible = false;
                title2.Visible = false;
                title4.Visible = false;
                title5.Visible = false;
                title7.Visible = false;
            }

        }

        // Search 

        private void tbQuery_TextChanged(object sender, EventArgs e)
        {
            fillFlow();
        }

        // Button Action

        private void btnAturPersediaan_Click(object sender, EventArgs e)
        {
            if (checkedId.Count > 0)
            {
                FormAturPersediaan tambahPersediaan = new FormAturPersediaan(this, false);
                tambahPersediaan.Show();
            }
            else MessageBox.Show("Harap ceklis barang yang ingin digunakan.");
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            FormTambahDataBarang tambahDataBarang = new FormTambahDataBarang(this, false);
            tambahDataBarang.Show();
        }

        private void btnBarangMasuk_Click(object sender, EventArgs e)
        {
            FormTambahBarangMasuk tambahBarangMasuk = new FormTambahBarangMasuk(this, false);
            tambahBarangMasuk.Show();
        }
        
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            if (checkedId.Count > 0)
            {
                FormBarangKeluar barangKeluar = new FormBarangKeluar(this);
                barangKeluar.Show();
            }
            else MessageBox.Show("Harap ceklis barang yang ingin dikeluarkan.");
        }

        private void btnCetakPersediaan_Click(object sender, EventArgs e)
        {
            FormLaporan laporan = new FormLaporan();
            laporan.printDoc();
        }

        // Filter Event

        private void filterEvent(object sender, EventArgs e)
        {
            cekRadio(radioSatuan, "satuan");
            cekRadio(radioJenis,  "jenis");
            cekRadio(radioTipe,   "tipe");
            cekRadio(radioKhusus, "khusus");
            cekRadio(radioBaik,   "baik");
            cekRadio(radioRusak,  "rusak");
            cekRadio(radioSemuaKondisi, "semuaKondisi");
            cekRadio(radioSemuaPenggunaan, "semuaPenggunaan");

            if (!atribut["satuan"]) cbTipe.Enabled = false;
            else cbTipe.Enabled = true;
            if (!atribut["khusus"]) cbPenggunaan.Enabled = false;
            else cbPenggunaan.Enabled = true;

            if (atribut["baik"]) kondisi = 1;
            else if (atribut["rusak"]) kondisi = 0;

            checkedId.Clear();
            checkedItem.Clear();
            fillFlow();
        }

        private void cekRadio(RadioButton radio, string atribut)
        {
            if (radio.Checked) this.atribut[atribut] = true;
            else this.atribut[atribut] = false;
        }

        private void resetTitle()
        {
            title1.Visible = true;
            title2.Visible = true;
            title3.Visible = true;
            title4.Visible = true;
            title5.Visible = true;
            title6.Visible = true;
            title7.Visible = true;
        }

        // Public Method 

        public static string getTanggal(DateTimePicker dateTimePicker)
        {
            DateTime dateTime = dateTimePicker.Value.Date;
            return dateTime.ToString("yyyy-MM-dd");
        }

        public static void setListBarang(ListBox listBox)
        {
            int i = 0;
            foreach (string item in checkedItem)
            {
                listBox.Items.Add(checkedId[i] + " - " + item);
                i++;
            }
        }

        public static void setKode(string table, ComboBox comboBox, Boolean semua)
        {
            MySqlCommand query = new MySqlCommand("SELECT * FROM " + table, conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            List<Object> items = new List<Object>();
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";

            if (semua) items.Add(new { Text = "Semua", Value = "0" });

            while (reader.Read())
            {
                string id = Convert.ToString(reader["id"]);
                string nama = Convert.ToString(reader["nama"]);

                items.Add(new { Text = id + " - " + nama, Value = id });
            }

            comboBox.DataSource = items;
            conn.Close();
        }

        public static void execute(MySqlCommand query)
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