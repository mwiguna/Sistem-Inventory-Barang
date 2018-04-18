using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventaris
{
    public partial class FormTambahUser : Form
    {
        MySqlConnection conn = ModelDatabase.conn;
        MySqlCommand query;
        UCUser ucUser;
        Boolean editPassword;
        int idUser;

        public FormTambahUser(UCUser ucUser, Boolean edit, int id = 0)
        {
            InitializeComponent();
            this.ucUser = ucUser;
            this.idUser = id;
            cbJabatan.SelectedIndex = 0;

            // Cek apakah ingin edit data atau tambah data
            if (edit)
            {
                editPassword       = false;
                tbPassword.Enabled = false;
                tbUlang.Enabled    = false;
                checkBox.Visible   = true;
                btnTambah.Visible  = false;
                setDataEdit();
            }
            else btnEdit.Visible = false;
        }

        // Cek ingin edit password atau tidak
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                editPassword = true;
                tbPassword.Enabled = true;
                tbUlang.Enabled = true;
            }
            else
            {
                editPassword = false;
                tbPassword.Enabled = false;
                tbUlang.Enabled = false;
            }
        }

        // Set Data TextBox Jika ingin edit
        private void setDataEdit()
        {
            query = new MySqlCommand("SELECT * FROM user WHERE id = '"+ idUser +"'", conn);
            conn.Open();
            MySqlDataReader reader = query.ExecuteReader();
            
            while (reader.Read())
            {
                tbNIP.Text  = Convert.ToString(reader["nip"]);
                tbNama.Text = Convert.ToString(reader["nama"]);
                cbJabatan.SelectedIndex = Convert.ToInt32(reader["role"]);
            }

            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Validasi Form
            if (tbNIP.Text != "" && tbNama.Text != "" && tbPassword.Text != "" && tbUlang.Text != "")
            {
                //Validasi Konfirmasi Password
                if (tbPassword.Text == tbUlang.Text)
                {
                    //Insert Data User
                    query = new MySqlCommand("INSERT INTO user (nip, nama, password, role) VALUES ('" + tbNIP.Text + "', '" + tbNama.Text + "', '" + ModelDatabase.HashPassword(tbPassword.Text) + "', '" + cbJabatan.SelectedIndex.ToString() + "' )", conn);
                    execute(query);
                } else MessageBox.Show("Password dan Konfirmasi Password tidak cocok");
            } else MessageBox.Show("Harap Lengkapi Form");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Validasi Form
            if (tbNIP.Text != "" && tbNama.Text != "")
            {
                // Validasi edit password atau tidak
                if (editPassword)
                {
                    if (tbPassword.Text != "" && tbUlang.Text != "")
                    {
                        if (tbPassword.Text == tbUlang.Text) query = new MySqlCommand("UPDATE user SET nip = '"+ tbNIP.Text + "', nama = '" + tbNama.Text + "', password = '" + ModelDatabase.HashPassword(tbPassword.Text) + "', role = '" + cbJabatan.SelectedIndex + "' WHERE id = '" + idUser + "'", conn);
                        else {
                            MessageBox.Show("Password dan Konfirmasi Password tidak cocok");
                            return;
                        }
                    } else {
                        MessageBox.Show("Harap Lengkapi Form");
                        return;
                    }
                } else query = new MySqlCommand("UPDATE user SET nip = '" + tbNIP.Text + "', nama = '" + tbNama.Text + "', role = '" + cbJabatan.SelectedIndex + "' WHERE id = '" + idUser + "'", conn);
                execute(query);
                Close();
            } else MessageBox.Show("Harap Lengkapi Form");
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
            ucUser.fillFlow();
        }
        
    }
}