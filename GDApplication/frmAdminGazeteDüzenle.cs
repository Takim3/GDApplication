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
    public partial class frmAdminGazeteDüzenle : Form
    {
        public frmAdminGazeteDüzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-1K5IIMK5;Initial Catalog=GazeteDergiApp;Integrated Security=True");
        DataSet dataSet = new DataSet();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAdminGazeteDüzenle_Load(object sender, EventArgs e)
        {
            GazeteDüzenle();
        }

        private void GazeteDüzenle()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from GazeteDergi", baglanti);
            adtr.Fill(dataSet, "GazeteDergi");
            dataGridView1.DataSource = dataSet.Tables["GazeteDergi"];
            baglanti.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from gazeteDergi where gazeteDergiAd='" + dataGridView1.CurrentRow.Cells["gazeteDergiAd"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["gazeteDergi"].Clear();
            GazeteDüzenle();
            MessageBox.Show("Kayıt silindi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isimtxt.Text = dataGridView1.CurrentRow.Cells["GazeteDergiAd"].Value.ToString();
            yayinevitxt.Text = dataGridView1.CurrentRow.Cells["YayınEvi"].Value.ToString();
            aciklamatxt.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            fiyattxt.Text = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update gazeteDergi set gazeteDergiAd=@gazeteDergiAd,yayınEvi=@yayinevi,aciklama=@aciklama,fiyat=@fiyat where gazeteDergiAd=@gazeteDergiAd  ", baglanti);
            komut.Parameters.AddWithValue("@gazeteDergiAd",isimtxt.Text);
            komut.Parameters.AddWithValue("@yayinevi", yayinevitxt.Text);
            komut.Parameters.AddWithValue("@aciklama", aciklamatxt.Text);
            komut.Parameters.AddWithValue("@fiyat",double.Parse( fiyattxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["gazeteDergi"].Clear();
            GazeteDüzenle();
            MessageBox.Show("Güncelleme yapıldı.");
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from gazeteDergi where gazeteDergiAd like '%" +txtAdAra.Text + "%'",baglanti);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
