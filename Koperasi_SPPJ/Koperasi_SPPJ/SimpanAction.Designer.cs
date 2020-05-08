namespace Koperasi_SPPJ
{
    partial class SimpanAction
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
            this.txtJml = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlah yang ingin disimpan";
            // 
            // txtJml
            // 
            this.txtJml.Location = new System.Drawing.Point(283, 64);
            this.txtJml.Name = "txtJml";
            this.txtJml.Size = new System.Drawing.Size(100, 22);
            this.txtJml.TabIndex = 1;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(245, 121);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 2;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(129, 121);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 23);
            this.btKembali.TabIndex = 6;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = true;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // SimpanAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 168);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.txtJml);
            this.Controls.Add(this.label1);
            this.Name = "SimpanAction";
            this.Text = "SimpanAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJml;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btKembali;
    }
}