using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormTambahJenisBarang : Form
    {
        MySqlConnection conn = ModelDatabase.conn;
        UCJenisBarang ucJenisBarang;
        int id;

        public FormTambahJenisBarang(UCJenisBarang ucJenisBarang, Boolean edit, int id = 0)
        {
            InitializeComponent();
            this.ucJenisBarang = ucJenisBarang;
            this.id = id;

            if (edit)
            {
                btnTambah.Visible = false;
                setDataEdit();
            }
            else btnEdit.Visible = false;
        }

        private void setDataEdit()
        {
            MySqlCommand query = new MySqlCommand("SELECT * FROM jenis_barang WHERE id = '" + id + "'", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                tbNama.Text = Convert.ToString(reader["nama"]);
            }

            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                MySqlCommand query = new MySqlCommand("INSERT INTO jenis_barang (nama) VALUES ('" + tbNama.Text + "')", conn);
                execute(query);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                MySqlCommand query = new MySqlCommand("UPDATE jenis_barang SET nama = '" + tbNama.Text + "' WHERE id = '" + id + "'", conn);
                execute(query);
                Close();
            }
        }

        private void execute(MySqlCommand query)
        {
            try
            {
                conn.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            ucJenisBarang.fillFlow();
        }
    }
}