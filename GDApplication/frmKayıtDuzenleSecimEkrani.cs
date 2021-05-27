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
    public partial class frmKayıtDuzenleSecimEkrani : Form
    {
        public frmKayıtDuzenleSecimEkrani()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmTelGuncelleme frmTellGuncelleme = new frmTelGuncelleme();
            frmTellGuncelleme.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAdresGuncelleme frmAdressGuncelleme = new frmAdresGuncelleme();
            frmAdressGuncelleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmİlceGuncelle frmİlceeGuncelle = new frmİlceGuncelle();
            frmİlceeGuncelle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSehirGuncelleme frmSehirrGuncelleme = new frmSehirGuncelleme();
            frmSehirrGuncelleme.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmailGuncelleme frmEmaillGuncelleme = new frmEmailGuncelleme();
            frmEmaillGuncelleme.ShowDialog();
        }

        private void frmKayıtDuzenleSecimEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
