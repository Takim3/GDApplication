using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDApplication
{
    public partial class frmAdminGörevSeçim : Form
    {
        public frmAdminGörevSeçim()
        {
            InitializeComponent();
        }

        private void frmAdminGörevSeçim_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdminGazeteDüzenle frmAdminGazeteDüzenle = new frmAdminGazeteDüzenle();
            frmAdminGazeteDüzenle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGDKayit frmGDKayit = new frmGDKayit();
            frmGDKayit.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdminSatisRaporu frmAdminSatisRaporu = new frmAdminSatisRaporu();
            frmAdminSatisRaporu.ShowDialog();
        }
    }
}
