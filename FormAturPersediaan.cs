using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormAturPersediaan : Form
    {
        UCPersediaan ucPersediaan;
        Boolean edit;

        public FormAturPersediaan(UCPersediaan ucPersediaan, Boolean edit)
        {
            InitializeComponent();
            this.ucPersediaan = ucPersediaan;
            this.edit = edit;

            UCPersediaan.setListBarang(listBox);
            UCPersediaan.setKode("ruangan", cbRuangan, false);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            foreach (string id in UCPersediaan.checkedId)
            {
                MySqlCommand query = new MySqlCommand("UPDATE satuan SET id_ruangan = '"+ cbRuangan.SelectedValue + "' WHERE id = '" + id + "'", ModelDatabase.conn);
                UCPersediaan.execute(query);
            }

            MessageBox.Show("Berhasil menambahkan Persediaan.");
            ucPersediaan.fillFlow();
        }
    }
}