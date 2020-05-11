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
    public partial class Simpan : Form
    {
        int idu;
        public Simpan(int id)
        {
            InitializeComponent();
            idu = id;
            load_table();
        }

        public void load_table()
        {
            var conn = new MySqlConnection("Host=localhost;Uid=root;Pwd=;Database=koperasi_sppj");
            var cmd = new MySqlCommand("SELECT status, tgl_simpan, jml_simpan, saldo from simpan where id_user = " + idu + "", conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                tbSimpan.DataSource = bs;
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

        private void btSimpan_Click(object sender, EventArgs e)
        {
            SimpanAction s = new SimpanAction(idu, this);
            s.Show();
        }

        private void btAmbil_Click(object sender, EventArgs e)
        {
            AmbilAction a = new AmbilAction(idu, this);
            a.Show();
        }
    }
}
