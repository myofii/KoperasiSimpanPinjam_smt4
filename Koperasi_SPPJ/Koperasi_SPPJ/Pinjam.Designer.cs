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
            this.btBayar.Location = new System.Drawing.Point(167, 120);
            this.btBayar.Name = "btBayar";
            this.btBayar.Size = new System.Drawing.Size(75, 23);
            this.btBayar.TabIndex = 11;
            this.btBayar.Text = "Bayar";
            this.btBayar.UseVisualStyleBackColor = true;
            this.btBayar.Click += new System.EventHandler(this.btBayar_Click);
            // 
            // btPinjam
            // 
            this.btPinjam.Location = new System.Drawing.Point(64, 120);
            this.btPinjam.Name = "btPinjam";
            this.btPinjam.Size = new System.Drawing.Size(75, 23);
            this.btPinjam.TabIndex = 10;
            this.btPinjam.Text = "Pinjam";
            this.btPinjam.UseVisualStyleBackColor = true;
            this.btPinjam.Click += new System.EventHandler(this.btPinjam_Click);
            // 
            // tbPinjam
            // 
            this.tbPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPinjam.Location = new System.Drawing.Point(64, 163);
            this.tbPinjam.Name = "tbPinjam";
            this.tbPinjam.RowTemplate.Height = 24;
            this.tbPinjam.Size = new System.Drawing.Size(672, 211);
            this.tbPinjam.TabIndex = 9;
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(64, 392);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 23);
            this.btKembali.TabIndex = 8;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = true;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(318, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pinjam";
            // 
            // Pinjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBayar);
            this.Controls.Add(this.btPinjam);
            this.Controls.Add(this.tbPinjam);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.label2);
            this.Name = "Pinjam";
            this.Text = "Pinjam";
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