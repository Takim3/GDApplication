using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDApplication
{
    public partial class frmAdminSatisRaporu : Form
    {
        public frmAdminSatisRaporu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-1K5IIMK5;Initial Catalog=GazeteDergiApp;Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void SatisListele()
        {
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select s.fatura_id as 'Fatura Numarası' ,TRIM(a.ad) + ' '+TRIM( a.soyad) as 'Müşteri Adı Soyadı', g.gazeteDergiAd as 'Gazete/Dergi İsmi',g.fiyat as 'Ücret',g.aciklama as 'Açıklama',s.tarih as 'Tarih' from satis s join GazeteDergi g on g.gazeteDergiAd =s.gazeteDergiAd " +
               "join AboneBilgileri a on s.kullaniciAdi=a.kullaniciAdi  ", baglanti);
            adtr.Fill(dataSet, "satis,aboneBilgileri,Gazetedergi");
            dataGridView1.DataSource = dataSet.Tables["satis,aboneBilgileri,Gazetedergi"];
            baglanti.Close();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(g.fiyat) from satis s join GazeteDergi g on g.gazeteDergiAd =s.gazeteDergiAd ", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

            }
        }

        private void say()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select count(fatura_id) from satis", baglanti);
                lblSatisSayısı.Text = komut.ExecuteScalar().ToString();
                baglanti.Close();
            }
            catch (Exception)
            {

            }


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdminSatisRaporu_Load(object sender, EventArgs e)
        {
            hesapla();
            say();
            SatisListele();
        }

        private void faturaArabtn_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select s.fatura_id as 'Fatura Numarası' ,TRIM(a.ad) + ' '+TRIM( a.soyad) as 'Müşteri Adı Soyadı', g.gazeteDergiAd as 'Gazete/Dergi İsmi',g.fiyat as 'Ücret',g.aciklama as 'Açıklama',s.tarih as 'Tarih' from satis s join GazeteDergi g on g.gazeteDergiAd =s.gazeteDergiAd " +
               "join AboneBilgileri a on s.kullaniciAdi=a.kullaniciAdi where fatura_id like '%" + faturaAra.Text + "%'", baglanti);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}

