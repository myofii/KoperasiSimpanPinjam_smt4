namespace Koperasi_SPPJ
{
    partial class Pinjam
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
            this.btBayar = new System.Windows.Forms.Button();
            this.btPinjam = new System.Windows.Forms.Button();
            this.tbPinjam = new System.Windows.Forms.DataGridView();
            this.btKembali = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPinjam)).BeginInit();
            this.SuspendLayout();
            // 
            // btBayar
            // 
            this.btBayar.BackColor = System.Drawing.Color.SkyBlue;
            this.btBayar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBayar.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBayar.Location = new System.Drawing.Point(167, 120);
            this.btBayar.Name = "btBayar";
            this.btBayar.Size = new System.Drawing.Size(79, 34);
            this.btBayar.TabIndex = 11;
            this.btBayar.Text = "Pay";
            this.btBayar.UseVisualStyleBackColor = false;
            this.btBayar.Click += new System.EventHandler(this.btBayar_Click);
            // 
            // btPinjam
            // 
            this.btPinjam.BackColor = System.Drawing.Color.SkyBlue;
            this.btPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPinjam.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPinjam.Location = new System.Drawing.Point(64, 120);
            this.btPinjam.Name = "btPinjam";
            this.btPinjam.Size = new System.Drawing.Size(75, 34);
            this.btPinjam.TabIndex = 10;
            this.btPinjam.Text = "Credit";
            this.btPinjam.UseVisualStyleBackColor = false;
            this.btPinjam.Click += new System.EventHandler(this.btPinjam_Click);
            // 
            // tbPinjam
            // 
            this.tbPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPinjam.Location = new System.Drawing.Point(64, 174);
            this.tbPinjam.Name = "tbPinjam";
            this.tbPinjam.RowTemplate.Height = 24;
            this.tbPinjam.Size = new System.Drawing.Size(672, 211);
            this.tbPinjam.TabIndex = 9;
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.SkyBlue;
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKembali.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembali.Location = new System.Drawing.Point(64, 403);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(87, 30);
            this.btKembali.TabIndex = 8;
            this.btKembali.Text = "Back";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(351, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loan";
            // 
            // Pinjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBayar);
            this.Controls.Add(this.btPinjam);
            this.Controls.Add(this.tbPinjam);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.label2);
            this.Name = "Pinjam";
            ((System.ComponentModel.ISupportInitialize)(this.tbPinjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBayar;
        private System.Windows.Forms.Button btPinjam;
        private System.Windows.Forms.DataGridView tbPinjam;
        private System.Windows.Forms.Button btKembali;
        private System.Windows.Forms.Label label2;
    }
}