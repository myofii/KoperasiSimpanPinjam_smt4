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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(315, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Simpan";
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(61, 406);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(75, 23);
            this.btKembali.TabIndex = 3;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = true;
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
            this.btSimpan.Location = new System.Drawing.Point(61, 134);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 5;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btAmbil
            // 
            this.btAmbil.Location = new System.Drawing.Point(164, 134);
            this.btAmbil.Name = "btAmbil";
            this.btAmbil.Size = new System.Drawing.Size(75, 23);
            this.btAmbil.TabIndex = 6;
            this.btAmbil.Text = "Ambil";
            this.btAmbil.UseVisualStyleBackColor = true;
            this.btAmbil.Click += new System.EventHandler(this.btAmbil_Click);
            // 
            // Simpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAmbil);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.tbSimpan);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.label2);
            this.Name = "Simpan";
            this.Text = "Simpan";
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