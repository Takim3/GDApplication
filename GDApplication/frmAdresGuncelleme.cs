using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GDApplication
{
    public partial class frmAdresGuncelleme : Form
    {
        public frmAdresGuncelleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtYeniAdres.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz!!");
            }
            else
            {
                string kullaniciAdi;
                string adres;
                kullaniciAdi = txtKullaniciAdi.Text;
                adres = txtYeniAdres.Text;
                SqlBaglantisi baglan = new SqlBaglantisi();
                SqlCommand komut = new SqlCommand("select * from AboneBilgileri Where kullaniciAdi='" + kullaniciAdi + "'", baglan.baglan());
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    SqlCommand guncelle = new SqlCommand("update AboneBilgileri set adres='" + adres + "'where kullaniciAdi='" + kullaniciAdi + "'", baglan.baglan());
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Adres Bilginiz Değiştirilmiştir.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Hatalı.");
                }
            }
        }

        private void frmAdresGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}
