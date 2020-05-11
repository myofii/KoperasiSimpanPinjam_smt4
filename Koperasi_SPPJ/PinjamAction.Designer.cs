namespace Koperasi_SPPJ
{
    partial class PinjamAction
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
            this.btPinjam = new System.Windows.Forms.Button();
            this.txtJml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPinjam
            // 
            this.btPinjam.Location = new System.Drawing.Point(234, 104);
            this.btPinjam.Name = "btPinjam";
            this.btPinjam.Size = new System.Drawing.Size(75, 23);
            this.btPinjam.TabIndex = 7;
            this.btPinjam.Text = "Pinjam";
            this.btPinjam.UseVisualStyleBackColor = true;
            this.btPinjam.Click += new System.EventHandler(this.btPinjam_Click);
            // 
            // txtJml
            // 
            this.txtJml.Location = new System.Drawing.Point(289, 51);
            this.txtJml.Name = "txtJml";
            this.txtJml.Size = new System.Drawing.Size(100, 22);
            this.txtJml.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jumlah yang ingin dipinjam";
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(130, 104);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 23);
            this.btKembali.TabIndex = 12;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = true;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // PinjamAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 168);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btPinjam);
            this.Controls.Add(this.txtJml);
            this.Controls.Add(this.label1);
            this.Name = "PinjamAction";
            this.Text = "PinjamAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPinjam;
        private System.Windows.Forms.TextBox txtJml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btKembali;
    }
}