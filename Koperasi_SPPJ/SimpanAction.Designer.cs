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
            this.label1.Location = new System.Drawing.Point(115, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the amount";
            // 
            // txtJml
            // 
            this.txtJml.Location = new System.Drawing.Point(244, 74);
            this.txtJml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJml.Name = "txtJml";
            this.txtJml.Size = new System.Drawing.Size(100, 28);
            this.txtJml.TabIndex = 1;
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.SkyBlue;
            this.btSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSimpan.ForeColor = System.Drawing.Color.Black;
            this.btSimpan.Location = new System.Drawing.Point(244, 142);
            this.btSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 29);
            this.btSimpan.TabIndex = 2;
            this.btSimpan.Text = "Ok";
            this.btSimpan.UseVisualStyleBackColor = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.SkyBlue;
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKembali.ForeColor = System.Drawing.Color.Black;
            this.btKembali.Location = new System.Drawing.Point(128, 142);
            this.btKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 29);
            this.btKembali.TabIndex = 6;
            this.btKembali.Text = "Back";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // SimpanAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(474, 210);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.txtJml);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimpanAction";
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