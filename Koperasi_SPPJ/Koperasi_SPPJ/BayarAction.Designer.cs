namespace Koperasi_SPPJ
{
    partial class BayarAction
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
            this.txtJml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBayar
            // 
            this.btBayar.BackColor = System.Drawing.Color.SkyBlue;
            this.btBayar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBayar.ForeColor = System.Drawing.Color.Black;
            this.btBayar.Location = new System.Drawing.Point(247, 133);
            this.btBayar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBayar.Name = "btBayar";
            this.btBayar.Size = new System.Drawing.Size(75, 29);
            this.btBayar.TabIndex = 10;
            this.btBayar.Text = "Ok";
            this.btBayar.UseVisualStyleBackColor = false;
            this.btBayar.Click += new System.EventHandler(this.btBayar_Click);
            // 
            // txtJml
            // 
            this.txtJml.Location = new System.Drawing.Point(247, 66);
            this.txtJml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJml.Name = "txtJml";
            this.txtJml.Size = new System.Drawing.Size(100, 28);
            this.txtJml.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(104, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input the amount";
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.SkyBlue;
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKembali.ForeColor = System.Drawing.Color.Black;
            this.btKembali.Location = new System.Drawing.Point(143, 133);
            this.btKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 29);
            this.btKembali.TabIndex = 11;
            this.btKembali.Text = "Back";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // BayarAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(474, 210);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btBayar);
            this.Controls.Add(this.txtJml);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BayarAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBayar;
        private System.Windows.Forms.TextBox txtJml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btKembali;
    }
}