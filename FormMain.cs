using System;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormMain : Form
    {
        Byte location = 0;
        String nama, jabatan;

        public FormMain(string nama, string jabatan)
        {
            InitializeComponent();
            
            this.nama = nama;
            this.jabatan = jabatan;
            setData();
            setAuth();
        }

        public void setData()
        {
            lblNama.Text   = nama;
            lblJabatan.Text = jabatan;
            UCPersediaan ucPersediaan = new UCPersediaan();
            panelMain.Controls.Add(ucPersediaan);
        }

        private void setAuth()
        {
            if(jabatan == "Manajer")
            {
                navJenis.Visible = false;
                navRuangan.Visible = false;
                navUser.Visible = false;
            }
            else if (jabatan == "Gudang")
            {
                navRiwayat.Visible = false;
                navUser.Visible = false;
            }
        }

        // Navigation

        private void navPersediaan_Click(object sender, EventArgs e)
        {
            if (location != 0)
            {
                UCPersediaan ucPersediaan = new UCPersediaan();
                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucPersediaan);
                location = 0;
            }
        }

        private void navJenis_Click(object sender, EventArgs e)
        {
            if (location != 1)
            {
                UCJenisBarang ucJenisBarang = new UCJenisBarang();
                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucJenisBarang);
                location = 1;
            }
        }

        private void navRuangan_Click(object sender, EventArgs e)
        {
            if (location != 2)
            {
                UCRuangan ucRuangan = new UCRuangan();
                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucRuangan);
                location = 2;
            }
        }

        private void navRiwayat_Click(object sender, EventArgs e)
        {
            if (location != 3)
            {
                UCRiwayat ucRiwayat = new UCRiwayat();
                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucRiwayat);
                location = 3;
            }
        }

        private void navUser_Click(object sender, EventArgs e)
        {
            if (location != 4)
            {
                UCUser ucUser = new UCUser();
                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucUser);
                location = 4;
            }
        }

        private void navLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}