namespace Koperasi_SPPJ
{
    partial class AmbilAction
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
            this.txtJml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAmbil = new System.Windows.Forms.Button();
            this.btKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJml
            // 
            this.txtJml.Location = new System.Drawing.Point(289, 73);
            this.txtJml.Name = "txtJml";
            this.txtJml.Size = new System.Drawing.Size(100, 22);
            this.txtJml.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jumlah yang ingin diambil";
            // 
            // btAmbil
            // 
            this.btAmbil.Location = new System.Drawing.Point(253, 117);
            this.btAmbil.Name = "btAmbil";
            this.btAmbil.Size = new System.Drawing.Size(75, 23);
            this.btAmbil.TabIndex = 4;
            this.btAmbil.Text = "Ambil";
            this.btAmbil.UseVisualStyleBackColor = true;
            this.btAmbil.Click += new System.EventHandler(this.btAmbil_Click_1);
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(130, 117);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 23);
            this.btKembali.TabIndex = 5;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = true;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // AmbilAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 168);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btAmbil);
            this.Controls.Add(this.txtJml);
            this.Controls.Add(this.label1);
            this.Name = "AmbilAction";
            this.Text = "AmbilAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAmbil;
        private System.Windows.Forms.Button btKembali;
    }
}