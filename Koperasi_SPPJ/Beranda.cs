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
    public partial class Beranda : Form
    {
        int idu;
        public Beranda(int id)
        {
            InitializeComponent();
            idu = id;
            var conn = new MySqlConnection("Host=localhost;Uid=root;Pwd=;Database=koperasi_sppj");
            var cmd = new MySqlCommand("SELECT nama_user, saldo_sp, saldo_pj from user where id_user = "+id+"", conn);
            conn.Open();

            var r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                r.Read();
                lbNama.Text = "" + r[0];
                lbSaldo_sp.Text = "Rp." + r[1];
                lbSaldo_pj.Text = "Rp." + r[2];
                r.Close();
            }
            conn.Close();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            Simpan s = new Simpan(idu);
            s.Show();
            this.Close();
        }

        private void btPinjam_Click(object sender, EventArgs e)
        {
            Pinjam p = new Pinjam(idu);
            p.Show();
            this.Close();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Beranda_Load(object sender, EventArgs e)
        {

        }
    }
}
