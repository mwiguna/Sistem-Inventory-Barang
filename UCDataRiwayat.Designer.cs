namespace Inventaris
{
    partial class UCDataRiwayat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHapus = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.tbJenis = new System.Windows.Forms.Label();
            this.tbTanggal = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Firebrick;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHapus.Location = new System.Drawing.Point(704, 3);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 18;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(155, 0);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(245, 17);
            this.tbNama.TabIndex = 16;
            this.tbNama.Text = "lblNama";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(59, 0);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(90, 17);
            this.tbID.TabIndex = 15;
            this.tbID.Text = "lblID";
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNo.Location = new System.Drawing.Point(3, 0);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(50, 17);
            this.tbNo.TabIndex = 14;
            this.tbNo.Text = "lblNo";
            // 
            // checkBox
            // 
            this.checkBox.Location = new System.Drawing.Point(638, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(60, 14);
            this.checkBox.TabIndex = 19;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // tbJenis
            // 
            this.tbJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJenis.Location = new System.Drawing.Point(406, 0);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(95, 17);
            this.tbJenis.TabIndex = 20;
            this.tbJenis.Text = "lblJenis";
            // 
            // tbTanggal
            // 
            this.tbTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTanggal.Location = new System.Drawing.Point(507, 0);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(125, 17);
            this.tbTanggal.TabIndex = 21;
            this.tbTanggal.Text = "lblTanggal";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbNo);
            this.flowLayoutPanel1.Controls.Add(this.tbID);
            this.flowLayoutPanel1.Controls.Add(this.tbNama);
            this.flowLayoutPanel1.Controls.Add(this.tbJenis);
            this.flowLayoutPanel1.Controls.Add(this.tbTanggal);
            this.flowLayoutPanel1.Controls.Add(this.checkBox);
            this.flowLayoutPanel1.Controls.Add(this.btnHapus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(782, 29);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // UCDataRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCDataRiwayat";
            this.Size = new System.Drawing.Size(785, 34);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label tbNama;
        private System.Windows.Forms.Label tbID;
        private System.Windows.Forms.Label tbNo;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label tbJenis;
        private System.Windows.Forms.Label tbTanggal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
