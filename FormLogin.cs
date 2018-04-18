using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventaris
{
    public partial class FormLogin : Form
    {
        ModelDatabase mDB = new ModelDatabase();
        string nama, jabatan;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbNIP.Text != "" && tbPassword.Text != "")
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM user WHERE nip = '" + tbNIP.Text + "' AND password = '" + ModelDatabase.HashPassword(tbPassword.Text) + "'", ModelDatabase.conn);
                ModelDatabase.conn.Open();
                MySqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nama = Convert.ToString(reader["nama"]);
                        int role = Convert.ToInt32(reader["role"]);

                        if (role == 0) jabatan = "Admin";
                        else if (role == 1) jabatan = "Manajer";
                        else jabatan = "Gudang";
                    }

                    ModelDatabase.conn.Close();
                    FormMain main = new FormMain(nama, jabatan);
                    Hide();
                    main.Show();
                }
                else MessageBox.Show("NIP atau Password salah.");
                ModelDatabase.conn.Close();
            }
            else MessageBox.Show("Harap lengkapi form.");
        }
    }
}