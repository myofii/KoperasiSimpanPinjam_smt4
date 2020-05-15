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
            this.logout = new System.Windows.Forms.LinkLabel();
            this.btPinjam = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.lbSaldo_sp = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSaldo_pj = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(250, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSaldo_pj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.logout);
            this.groupBox1.Controls.Add(this.btPinjam);
            this.groupBox1.Controls.Add(this.btSimpan);
            this.groupBox1.Controls.Add(this.lbSaldo_sp);
            this.groupBox1.Controls.Add(this.lbNama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(22, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(556, 337);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.LinkColor = System.Drawing.Color.Gainsboro;
            this.logout.Location = new System.Drawing.Point(494, 314);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(58, 20);
            this.logout.TabIndex = 6;
            this.logout.TabStop = true;
            this.logout.Text = "Log Out";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // btPinjam
            // 
            this.btPinjam.BackColor = System.Drawing.Color.Red;
            this.btPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPinjam.ForeColor = System.Drawing.Color.White;
            this.btPinjam.Location = new System.Drawing.Point(338, 83);
            this.btPinjam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPinjam.Name = "btPinjam";
            this.btPinjam.Size = new System.Drawing.Size(117, 62);
            this.btPinjam.TabIndex = 5;
            this.btPinjam.Text = "Loan";
            this.btPinjam.UseVisualStyleBackColor = false;
            this.btPinjam.Click += new System.EventHandler(this.btPinjam_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.Green;
            this.btSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSimpan.ForeColor = System.Drawing.Color.White;
            this.btSimpan.Location = new System.Drawing.Point(96, 83);
            this.btSimpan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(117, 62);
            this.btSimpan.TabIndex = 4;
            this.btSimpan.Text = "Saving";
            this.btSimpan.UseVisualStyleBackColor = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // lbSaldo_sp
            // 
            this.lbSaldo_sp.AutoSize = true;
            this.lbSaldo_sp.Location = new System.Drawing.Point(155, 268);
            this.lbSaldo_sp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSaldo_sp.Name = "lbSaldo_sp";
            this.lbSaldo_sp.Size = new System.Drawing.Size(0, 20);
            this.lbSaldo_sp.TabIndex = 3;
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(155, 233);
            this.lbNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(0, 20);
            this.lbNama.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saldo Penyimpanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saldo Peminjaman";
            // 
            // lbSaldo_pj
            // 
            this.lbSaldo_pj.AutoSize = true;
            this.lbSaldo_pj.Location = new System.Drawing.Point(155, 302);
            this.lbSaldo_pj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSaldo_pj.Name = "lbSaldo_pj";
            this.lbSaldo_pj.Size = new System.Drawing.Size(0, 20);
            this.lbSaldo_pj.TabIndex = 8;
            // 
            // Beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Beranda";
            this.Load += new System.EventHandler(this.Beranda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSaldo_sp;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPinjam;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.Label lbSaldo_pj;
        private System.Windows.Forms.Label label5;
    }
}