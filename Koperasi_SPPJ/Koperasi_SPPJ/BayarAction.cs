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
    public partial class BayarAction : Form
    {
        int idu;
        public BayarAction(int id)
        {
            InitializeComponent();
            idu = id;
        }

        private void btBayar_Click(object sender, EventArgs e)
        {
            int jml = Int32.Parse(txtJml.Text);
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
            saldo += jml;
            var cmd1 = new MySqlCommand("UPDATE user set saldo = " + saldo + " where id_user = " + idu + "",conn);
            var cmd2 = new MySqlCommand("", conn);
            string query = string.Format("INSERT INTO pinjam (id_user, tgl_pinjam, jml_pinjam, status, saldo) "
              + "VALUES ({0}, NOW(), {1}, 'BAYAR', {2})", new object[] {
                    idu,
                    jml,
                    saldo
              });
            cmd2.CommandText = query;
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Berhasil dibayar!!!");

            Pinjam p = new Pinjam(idu);
            p.Show();
            this.Close();
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Pinjam p = new Pinjam(idu);
            p.Show();
            this.Close();
        }
    }
}
