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
    public partial class frmAboneKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PS76OG9;Initial Catalog=GazeteDergiApp;Integrated Security=True");
        public frmAboneKayit()
        {
            InitializeComponent();
        }
      
        private void frmAboneKayit_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into YeniAbone(kullaniciAdi,GazeteDergiAd) values(@kullaniciAdi,@GazeteDergiAd)", baglanti);
            komut.Parameters.AddWithValue("(@kullaniciAdi", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@GazeteDergiAd", txtGDad.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Yeni Kayıt Oluşturuldu.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            /*frmMakbuz makbuz = new frmMakbuz();
            makbuz.ShowDialog();
            */


            baglanti.Close();
        }
    }
}
