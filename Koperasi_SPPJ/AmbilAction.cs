using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Koperasi_SPPJ
{
    public partial class AmbilAction : Form
    {
        int idu;
        Simpan sim;
        public AmbilAction(int id, Simpan s)
        {
            InitializeComponent();
            idu = id;
            sim = s;
        }

        private void btAmbil_Click_1(object sender, EventArgs e)
        {
            int jml = 0;
            if (txtJml.Text != "")
            {
                jml = Int32.Parse(txtJml.Text);

                int saldo = 0;
                var conn = new MySqlConnection("Host=localhost;Uid=root;Pwd=;Database=koperasi_sppj");
                var cmd = new MySqlCommand("SELECT saldo from user where id_user = " + idu + "", conn);
                conn.Open();
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    saldo = (int)r[0];
                    r.Close();
                }
                saldo -= jml;
                var cmd1 = new MySqlCommand("UPDATE user set saldo = " + saldo + " where id_user = " + idu + "", conn);
                var cmd2 = new MySqlCommand("", conn);
                string query = string.Format("INSERT INTO simpan (id_user, tgl_simpan, jml_simpan, status, saldo) "
                  + "VALUES ({0}, NOW(), {1}, 'AMBIL', {2})", new object[] {
                    idu,
                    jml,
                    saldo
                  });
                cmd2.CommandText = query;
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();

                sim.load_table();

                MessageBox.Show("Berhasil diambil!!!");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Inputkan jumlah uang yang ingin diambil!!");
            }
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
