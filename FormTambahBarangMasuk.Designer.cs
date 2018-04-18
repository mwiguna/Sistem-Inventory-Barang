namespace Inventaris
{
    partial class FormTambahBarangMasuk
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pID = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pKode = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKode = new System.Windows.Forms.ComboBox();
            this.pJumlah = new System.Windows.Forms.Panel();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pKondisi = new System.Windows.Forms.Panel();
            this.cbKondisi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pPenggunaan = new System.Windows.Forms.Panel();
            this.cbPenggunaan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pTanggal = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pID.SuspendLayout();
            this.pKode.SuspendLayout();
            this.pJumlah.SuspendLayout();
            this.pKondisi.SuspendLayout();
            this.pPenggunaan.SuspendLayout();
            this.pTanggal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 290);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pID);
            this.flowLayoutPanel2.Controls.Add(this.pKode);
            this.flowLayoutPanel2.Controls.Add(this.pJumlah);
            this.flowLayoutPanel2.Controls.Add(this.pKondisi);
            this.flowLayoutPanel2.Controls.Add(this.pPenggunaan);
            this.flowLayoutPanel2.Controls.Add(this.pTanggal);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 40);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(379, 197);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // pID
            // 
            this.pID.Controls.Add(this.tbID);
            this.pID.Controls.Add(this.label5);
            this.pID.Location = new System.Drawing.Point(3, 3);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(376, 27);
            this.pID.TabIndex = 67;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(98, 3);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(275, 20);
            this.tbID.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "ID Barang";
            // 
            // pKode
            // 
            this.pKode.Controls.Add(this.label2);
            this.pKode.Controls.Add(this.cbKode);
            this.pKode.Location = new System.Drawing.Point(3, 36);
            this.pKode.Name = "pKode";
            this.pKode.Size = new System.Drawing.Size(376, 27);
            this.pKode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kode";
            // 
            // cbKode
            // 
            this.cbKode.FormattingEnabled = true;
            this.cbKode.Location = new System.Drawing.Point(98, 3);
            this.cbKode.Name = "cbKode";
            this.cbKode.Size = new System.Drawing.Size(275, 21);
            this.cbKode.TabIndex = 63;
            // 
            // pJumlah
            // 
            this.pJumlah.Controls.Add(this.tbJumlah);
            this.pJumlah.Controls.Add(this.label3);
            this.pJumlah.Location = new System.Drawing.Point(3, 69);
            this.pJumlah.Name = "pJumlah";
            this.pJumlah.Size = new System.Drawing.Size(376, 27);
            this.pJumlah.TabIndex = 4;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(98, 4);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(275, 20);
            this.tbJumlah.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Jumlah";
            // 
            // pKondisi
            // 
            this.pKondisi.Controls.Add(this.cbKondisi);
            this.pKondisi.Controls.Add(this.label4);
            this.pKondisi.Location = new System.Drawing.Point(3, 102);
            this.pKondisi.Name = "pKondisi";
            this.pKondisi.Size = new System.Drawing.Size(376, 27);
            this.pKondisi.TabIndex = 66;
            // 
            // cbKondisi
            // 
            this.cbKondisi.FormattingEnabled = true;
            this.cbKondisi.Location = new System.Drawing.Point(98, 3);
            this.cbKondisi.Name = "cbKondisi";
            this.cbKondisi.Size = new System.Drawing.Size(275, 21);
            this.cbKondisi.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Kondisi";
            // 
            // pPenggunaan
            // 
            this.pPenggunaan.Controls.Add(this.cbPenggunaan);
            this.pPenggunaan.Controls.Add(this.label6);
            this.pPenggunaan.Location = new System.Drawing.Point(3, 135);
            this.pPenggunaan.Name = "pPenggunaan";
            this.pPenggunaan.Size = new System.Drawing.Size(376, 27);
            this.pPenggunaan.TabIndex = 67;
            // 
            // cbPenggunaan
            // 
            this.cbPenggunaan.FormattingEnabled = true;
            this.cbPenggunaan.Location = new System.Drawing.Point(98, 3);
            this.cbPenggunaan.Name = "cbPenggunaan";
            this.cbPenggunaan.Size = new System.Drawing.Size(275, 21);
            this.cbPenggunaan.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Penggunaan";
            // 
            // pTanggal
            // 
            this.pTanggal.Controls.Add(this.dateTimePicker);
            this.pTanggal.Controls.Add(this.label7);
            this.pTanggal.Location = new System.Drawing.Point(3, 168);
            this.pTanggal.Name = "pTanggal";
            this.pTanggal.Size = new System.Drawing.Size(376, 27);
            this.pTanggal.TabIndex = 68;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(98, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(278, 20);
            this.dateTimePicker.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tanggal";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTambah);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(272, 35);
            this.flowLayoutPanel1.TabIndex = 61;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTambah.Location = new System.Drawing.Point(3, 3);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(129, 29);
            this.btnTambah.TabIndex = 56;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(138, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 29);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barang Masuk";
            // 
            // FormTambahBarangMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 307);
            this.Controls.Add(this.panel1);
            this.Name = "FormTambahBarangMasuk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Barang Masuk";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pID.ResumeLayout(false);
            this.pID.PerformLayout();
            this.pKode.ResumeLayout(false);
            this.pKode.PerformLayout();
            this.pJumlah.ResumeLayout(false);
            this.pJumlah.PerformLayout();
            this.pKondisi.ResumeLayout(false);
            this.pKondisi.PerformLayout();
            this.pPenggunaan.ResumeLayout(false);
            this.pPenggunaan.PerformLayout();
            this.pTanggal.ResumeLayout(false);
            this.pTanggal.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKode;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pKode;
        private System.Windows.Forms.Panel pJumlah;
        private System.Windows.Forms.Panel pKondisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pPenggunaan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPenggunaan;
        private System.Windows.Forms.ComboBox cbKondisi;
        private System.Windows.Forms.Panel pTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
    }
}