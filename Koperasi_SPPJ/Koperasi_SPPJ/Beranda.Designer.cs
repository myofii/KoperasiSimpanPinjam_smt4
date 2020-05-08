namespace Koperasi_SPPJ
{
    partial class Beranda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btPinjam = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(316, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beranda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logout);
            this.groupBox1.Controls.Add(this.btPinjam);
            this.groupBox1.Controls.Add(this.btSimpan);
            this.groupBox1.Controls.Add(this.lbSaldo);
            this.groupBox1.Controls.Add(this.lbNama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 337);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(83, 298);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(0, 17);
            this.lbSaldo.TabIndex = 3;
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(83, 263);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(0, 17);
            this.lbNama.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nama";
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.Blue;
            this.btSimpan.ForeColor = System.Drawing.Color.White;
            this.btSimpan.Location = new System.Drawing.Point(128, 83);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(156, 62);
            this.btSimpan.TabIndex = 4;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btPinjam
            // 
            this.btPinjam.BackColor = System.Drawing.Color.Red;
            this.btPinjam.ForeColor = System.Drawing.Color.White;
            this.btPinjam.Location = new System.Drawing.Point(451, 83);
            this.btPinjam.Name = "btPinjam";
            this.btPinjam.Size = new System.Drawing.Size(156, 62);
            this.btPinjam.TabIndex = 5;
            this.btPinjam.Text = "Pinjam";
            this.btPinjam.UseVisualStyleBackColor = false;
            this.btPinjam.Click += new System.EventHandler(this.btPinjam_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Location = new System.Drawing.Point(677, 317);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(59, 17);
            this.logout.TabIndex = 6;
            this.logout.TabStop = true;
            this.logout.Text = "Log Out";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // Beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Beranda";
            this.Text = "Beranda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPinjam;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.LinkLabel logout;
    }
}