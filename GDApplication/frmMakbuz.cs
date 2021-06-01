using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GDApplication
{
    public partial class frmMakbuz : Form
    {
        public frmMakbuz()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-1K5IIMK5;Initial Catalog=GazeteDergiApp;Integrated Security=True");
        DataSet daset = new DataSet();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMakbuz_Load(object sender, EventArgs e)
        {
           // KayitGoster();
        }

        //private void KayitGoster()
        //{
        //    baglanti.Open();
        //    SqlDataAdapter dap = new SqlDataAdapter("SELECT *FROM makbuzSon",baglanti);
        //    dap.Fill(daset,"makbuzSon");
        //    dataGridView1.DataSource = daset.Tables["makbuzSon"];
        //    baglanti.Close();
        //}
        private void txtTarih_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT *FROM makbuzSon where kullaniciAdi like '%" + txtTarih.Text + "%'",baglanti);
            dap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
