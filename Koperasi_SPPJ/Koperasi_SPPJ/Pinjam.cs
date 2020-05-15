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
    public partial class Pinjam : Form
    {
        int idu;
        public Pinjam(int id)
        {
            InitializeComponent();
            idu = id;
            load_table();
        }

        public void load_table()
        {
            var conn = new MySqlConnection("Host=localhost;Uid=root;Pwd=;Database=koperasi_sppj");
            var cmd = new MySqlCommand("SELECT status AS Status, tgl_pinjam AS Date, jml_pinjam AS Amount, saldo AS Saldo from pinjam where id_user = " + idu + "", conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                tbPinjam.DataSource = bs;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Beranda b = new Beranda(idu);
            b.Show();
            this.Close();
        }

        private void btPinjam_Click(object sender, EventArgs e)
        {
            PinjamAction p = new PinjamAction(idu, this);
            p.Show();
        }

        private void btBayar_Click(object sender, EventArgs e)
        {
            BayarAction b = new BayarAction(idu, this);
            b.Show();
        }

        private void btKembali_Click_1(object sender, EventArgs e)
        {
            Beranda b = new Beranda(idu);
            b.Show();
            this.Close();
        }
    }
}
