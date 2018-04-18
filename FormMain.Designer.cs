namespace Inventaris
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navPersediaan = new System.Windows.Forms.Button();
            this.navJenis = new System.Windows.Forms.Button();
            this.navRuangan = new System.Windows.Forms.Button();
            this.navRiwayat = new System.Windows.Forms.Button();
            this.navUser = new System.Windows.Forms.Button();
            this.navLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 706);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.navPersediaan);
            this.flowLayoutPanel1.Controls.Add(this.navJenis);
            this.flowLayoutPanel1.Controls.Add(this.navRuangan);
            this.flowLayoutPanel1.Controls.Add(this.navRiwayat);
            this.flowLayoutPanel1.Controls.Add(this.navUser);
            this.flowLayoutPanel1.Controls.Add(this.navLogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 323);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // navPersediaan
            // 
            this.navPersediaan.BackColor = System.Drawing.Color.RoyalBlue;
            this.navPersediaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navPersediaan.FlatAppearance.BorderSize = 0;
            this.navPersediaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navPersediaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPersediaan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navPersediaan.Location = new System.Drawing.Point(3, 3);
            this.navPersediaan.Name = "navPersediaan";
            this.navPersediaan.Size = new System.Drawing.Size(213, 48);
            this.navPersediaan.TabIndex = 0;
            this.navPersediaan.Text = "   Persediaan";
            this.navPersediaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPersediaan.UseVisualStyleBackColor = false;
            this.navPersediaan.Click += new System.EventHandler(this.navPersediaan_Click);
            // 
            // navJenis
            // 
            this.navJenis.BackColor = System.Drawing.Color.RoyalBlue;
            this.navJenis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navJenis.FlatAppearance.BorderSize = 0;
            this.navJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navJenis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navJenis.Location = new System.Drawing.Point(3, 57);
            this.navJenis.Name = "navJenis";
            this.navJenis.Size = new System.Drawing.Size(212, 48);
            this.navJenis.TabIndex = 3;
            this.navJenis.Text = "   Data Jenis Barang";
            this.navJenis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navJenis.UseVisualStyleBackColor = false;
            this.navJenis.Click += new System.EventHandler(this.navJenis_Click);
            // 
            // navRuangan
            // 
            this.navRuangan.BackColor = System.Drawing.Color.RoyalBlue;
            this.navRuangan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navRuangan.FlatAppearance.BorderSize = 0;
            this.navRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navRuangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navRuangan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navRuangan.Location = new System.Drawing.Point(3, 111);
            this.navRuangan.Name = "navRuangan";
            this.navRuangan.Size = new System.Drawing.Size(212, 48);
            this.navRuangan.TabIndex = 4;
            this.navRuangan.Text = "   Data Ruangan";
            this.navRuangan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navRuangan.UseVisualStyleBackColor = false;
            this.navRuangan.Click += new System.EventHandler(this.navRuangan_Click);
            // 
            // navRiwayat
            // 
            this.navRiwayat.BackColor = System.Drawing.Color.RoyalBlue;
            this.navRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navRiwayat.FlatAppearance.BorderSize = 0;
            this.navRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navRiwayat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navRiwayat.Location = new System.Drawing.Point(3, 165);
            this.navRiwayat.Name = "navRiwayat";
            this.navRiwayat.Size = new System.Drawing.Size(212, 48);
            this.navRiwayat.TabIndex = 7;
            this.navRiwayat.Text = "   Riwayat";
            this.navRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navRiwayat.UseVisualStyleBackColor = false;
            this.navRiwayat.Click += new System.EventHandler(this.navRiwayat_Click);
            // 
            // navUser
            // 
            this.navUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.navUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navUser.FlatAppearance.BorderSize = 0;
            this.navUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navUser.Location = new System.Drawing.Point(3, 219);
            this.navUser.Name = "navUser";
            this.navUser.Size = new System.Drawing.Size(212, 48);
            this.navUser.TabIndex = 5;
            this.navUser.Text = "   User";
            this.navUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navUser.UseVisualStyleBackColor = false;
            this.navUser.Click += new System.EventHandler(this.navUser_Click);
            // 
            // navLogout
            // 
            this.navLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.navLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navLogout.FlatAppearance.BorderSize = 0;
            this.navLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navLogout.Location = new System.Drawing.Point(3, 273);
            this.navLogout.Name = "navLogout";
            this.navLogout.Size = new System.Drawing.Size(212, 48);
            this.navLogout.TabIndex = 6;
            this.navLogout.Text = "   Logout";
            this.navLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navLogout.UseVisualStyleBackColor = false;
            this.navLogout.Click += new System.EventHandler(this.navLogout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblJabatan);
            this.panel3.Controls.Add(this.lblNama);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 130);
            this.panel3.TabIndex = 2;
            // 
            // lblJabatan
            // 
            this.lblJabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJabatan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJabatan.Location = new System.Drawing.Point(-1, 65);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(213, 22);
            this.lblJabatan.TabIndex = 2;
            this.lblJabatan.Text = "Manajer";
            this.lblJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNama
            // 
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNama.Location = new System.Drawing.Point(-1, 36);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(210, 20);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Hilman";
            this.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMain.Location = new System.Drawing.Point(238, 23);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1105, 660);
            this.panelMain.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1350, 706);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Sistem Inventaris Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button navRiwayat;
        private System.Windows.Forms.Button navLogout;
        private System.Windows.Forms.Button navUser;
        private System.Windows.Forms.Button navRuangan;
        private System.Windows.Forms.Button navJenis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblJabatan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button navPersediaan;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}