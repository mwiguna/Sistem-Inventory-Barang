using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormBarangKeluar : Form
    {
        UCPersediaan ucPersediaan;

        public FormBarangKeluar(UCPersediaan ucPersediaan)
        {
            InitializeComponent();

            this.ucPersediaan = ucPersediaan;
            UCPersediaan.setListBarang(listBox);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            
            var confirmResult = MessageBox.Show("Yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (string id in UCPersediaan.checkedId)
                {
                    MySqlCommand query = new MySqlCommand("INSERT INTO riwayat (id_satuan, tanggal, jenis) VALUES ('" + id + "', '" + UCPersediaan.getTanggal(dateTimePicker) + "', '0')", ModelDatabase.conn);
                    UCPersediaan.execute(query);
                }

                MessageBox.Show("Berhasil mengeluarkan barang! Menunggu konfirmasi manajer.");
                ucPersediaan.fillFlow();
            }
        }
        
    }
}