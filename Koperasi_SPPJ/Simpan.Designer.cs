namespace Koperasi_SPPJ
{
    partial class Simpan
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
            this.label2 = new System.Windows.Forms.Label();
            this.btKembali = new System.Windows.Forms.Button();
            this.tbSimpan = new System.Windows.Forms.DataGridView();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btAmbil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimpan)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(339, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saving";
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.SkyBlue;
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKembali.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembali.ForeColor = System.Drawing.Color.Black;
            this.btKembali.Location = new System.Drawing.Point(61, 406);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(87, 32);
            this.btKembali.TabIndex = 3;
            this.btKembali.Text = "Back";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // tbSimpan
            // 
            this.tbSimpan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbSimpan.Location = new System.Drawing.Point(61, 177);
            this.tbSimpan.Name = "tbSimpan";
            this.tbSimpan.RowTemplate.Height = 24;
            this.tbSimpan.Size = new System.Drawing.Size(672, 211);
            this.tbSimpan.TabIndex = 4;
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.SkyBlue;
            this.btSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSimpan.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimpan.ForeColor = System.Drawing.Color.Black;
            this.btSimpan.Location = new System.Drawing.Point(61, 120);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(87, 37);
            this.btSimpan.TabIndex = 5;
            this.btSimpan.Text = "Debet";
            this.btSimpan.UseVisualStyleBackColor = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btAmbil
            // 
            this.btAmbil.BackColor = System.Drawing.Color.SkyBlue;
            this.btAmbil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAmbil.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAmbil.ForeColor = System.Drawing.Color.Black;
            this.btAmbil.Location = new System.Drawing.Point(164, 120);
            this.btAmbil.Name = "btAmbil";
            this.btAmbil.Size = new System.Drawing.Size(102, 37);
            this.btAmbil.TabIndex = 6;
            this.btAmbil.Text = "Withdraw";
            this.btAmbil.UseVisualStyleBackColor = false;
            this.btAmbil.Click += new System.EventHandler(this.btAmbil_Click);
            // 
            // Simpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAmbil);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.tbSimpan);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.label2);
            this.Name = "Simpan";
            ((System.ComponentModel.ISupportInitialize)(this.tbSimpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btKembali;
        private System.Windows.Forms.DataGridView tbSimpan;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btAmbil;
    }
}