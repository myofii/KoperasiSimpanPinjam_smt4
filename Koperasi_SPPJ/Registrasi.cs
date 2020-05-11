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
    public partial class Registrasi : Form
    {
        LoginForm log;
        public Registrasi(LoginForm l)
        {
            InitializeComponent();
            log = l;
        }

        private void btDaftar_Click(object sender, EventArgs e)
        {
            if(txtNama.Text != "" | txtUsername.Text != "" | txtPassword.Text != "" | txtAlamat.Text != "" | txtNohp.Text != "")
            {
                var conn = new MySqlConnection("Host=localhost;Uid=root;Pwd=;Database=koperasi_sppj");
                var cmd = new MySqlCommand("", conn);

                var nama = txtNama.Text;
                var u = txtUsername.Text;
                var p = txtPassword.Text;
                var alamat = txtAlamat.Text;
                var nohp = txtNohp.Text;

                string query = string.Format("INSERT INTO user (username, password, nama_user, alamat, no_hp, saldo) "
                  + "VALUES ('{0}','{1}','{2}', '{3}', {4}, 0)", new object[] {
                    u,
                    p,
                    nama,
                    alamat,
                    nohp
                  });
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registrasi Berhasil !!!");

                log.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lengkapi Form Registrasi !!!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log.Show();
            this.Close();
        }

        private void Registrasi_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
