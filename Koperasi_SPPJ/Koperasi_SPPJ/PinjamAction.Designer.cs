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
            this.btPinjam.BackColor = System.Drawing.Color.SkyBlue;
            this.btPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPinjam.ForeColor = System.Drawing.Color.Black;
            this.btPinjam.Location = new System.Drawing.Point(238, 136);
            this.btPinjam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPinjam.Name = "btPinjam";
            this.btPinjam.Size = new System.Drawing.Size(75, 29);
            this.btPinjam.TabIndex = 7;
            this.btPinjam.Text = "Ok";
            this.btPinjam.UseVisualStyleBackColor = false;
            this.btPinjam.Click += new System.EventHandler(this.btPinjam_Click);
            // 
            // txtJml
            // 
            this.txtJml.Location = new System.Drawing.Point(238, 70);
            this.txtJml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJml.Name = "txtJml";
            this.txtJml.Size = new System.Drawing.Size(100, 28);
            this.txtJml.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(110, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input the amount";
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.SkyBlue;
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKembali.ForeColor = System.Drawing.Color.Black;
            this.btKembali.Location = new System.Drawing.Point(130, 136);
            this.btKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 29);
            this.btKembali.TabIndex = 12;
            this.btKembali.Text = "Back";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // PinjamAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(474, 210);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btPinjam);
            this.Controls.Add(this.txtJml);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PinjamAction";
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