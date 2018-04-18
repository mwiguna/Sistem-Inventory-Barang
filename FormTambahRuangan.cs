using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormTambahRuangan : Form
    {
        MySqlConnection conn = ModelDatabase.conn;
        UCRuangan ucRuangan;
        int id;

        public FormTambahRuangan(UCRuangan ucRuangan, Boolean edit, int id = 0)
        {
            InitializeComponent();
            this.ucRuangan = ucRuangan;
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
            MySqlCommand query = new MySqlCommand("SELECT * FROM ruangan WHERE id = '" + id + "'", conn);
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
                MySqlCommand query = new MySqlCommand("INSERT INTO ruangan (nama) VALUES ('"+ tbNama.Text +"')", conn);
                execute(query);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tbNama.Text != "")
            {
                MySqlCommand query = new MySqlCommand("UPDATE ruangan SET nama = '" + tbNama.Text + "' WHERE id = '"+ id +"'", conn);
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
            ucRuangan.fillFlow();
        }
    }
}