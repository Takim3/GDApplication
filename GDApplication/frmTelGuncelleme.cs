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
    public partial class frmTelGuncelleme : Form
    {
        public frmTelGuncelleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtYeniTelNo.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz!!");
            }
            else
            {
                string kullaniciAdi;
                string telNo;
                kullaniciAdi = txtKullaniciAdi.Text;
                telNo = txtYeniTelNo.Text;
                SqlBaglantisi baglan = new SqlBaglantisi();
                SqlCommand komut = new SqlCommand("select * from AboneBilgileri Where kullaniciAdi='" + kullaniciAdi + "'", baglan.baglan());
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    SqlCommand guncelle = new SqlCommand("update AboneBilgileri set telefonNo='" + telNo + "'where kullaniciAdi='" + kullaniciAdi + "'", baglan.baglan());
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Telefon Numaranız Değiştirilmiştir.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Hatalı.");
                }
            }
        }
    }
}
