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
    public partial class frmGDKayit : Form
    {
        public frmGDKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-1K5IIMK5;Initial Catalog=GazeteDergiApp;Integrated Security=True");

        private void frmGDKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into GazeteDergi(GazeteDergiAd,Yayınevi,Aciklama,Fiyat) values(@GazeteDergiAd,@Yayınevi,@Aciklama,@Fiyat)",baglanti);
            komut.Parameters.AddWithValue("@GazeteDergiAd", txtAd.Text);
            komut.Parameters.AddWithValue("@Yayınevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            komut.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
            baglanti.Close();
            MessageBox.Show("Yeni Kayıt Oluşturuldu.");
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
