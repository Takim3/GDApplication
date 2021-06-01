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
        SqlConnection baglanti = frmHesapAyarlari.baglanti;
        public frmAboneKayit()
        {
            InitializeComponent();
        }
      
        private void frmAboneKayit_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToLongDateString();

            kategoriGetir();
        }

        private void kategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from GazeteDergi", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxGDadi.Items.Add(read["GazeteDergiAd"].ToString());
            }
            baglanti.Close();
        }



        private void txtTCno_TextChanged(object sender, EventArgs e)
        {
            if (txtTCno.Text =="") foreach(Control item in Controls) if(item is TextBox) item.Text="";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AboneBilgileri where tcNo like '"+txtTCno.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKullaniciAd.Text = read["kullaniciAdi"].ToString();
            }
            baglanti.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into YeniAbone(kullaniciAdi,GazeteDergiAd) values('" + txtKullaniciAd.Text + "','" + comboBoxGDadi.Text + "')", baglanti);
            //komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAd.Text);
            //komut.Parameters.AddWithValue("@GazeteDergiAd", comboBoxGDadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

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


           
        }
    }
}
