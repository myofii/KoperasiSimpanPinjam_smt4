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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;
            int id;
            var conn = new MySqlConnection("Host=localhost;Uid=root;Pwd=;Database=koperasi_sppj");
            var cmd = new MySqlCommand("SELECT * from user where username='"+u+"' and password='"+p+"'", conn);
            conn.Open();

            var r = cmd.ExecuteReader();
            if(r.HasRows)
            {
                r.Read();
                id = Int32.Parse(""+r[0]);
                r.Close();
                Beranda b = new Beranda(id);
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Tidak Ditemukan");
            }

            conn.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm log = new LoginForm();
            log = this;
            Registrasi reg = new Registrasi(log);
            reg.Show();
            this.Hide();
        }
    }
}
