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
    public partial class frmAboneGorevEkrani : Form
    {
        public frmAboneGorevEkrani()
        {
            InitializeComponent();
        }

        private void btnHesapAyarlari_Click(object sender, EventArgs e)
        {
            frmHesapAyarlari hesap_ayarlari = new frmHesapAyarlari() ;
            hesap_ayarlari.ShowDialog();
        }

        private void btnMakbuzGoruntule_Click(object sender, EventArgs e)
        {
            frmMakbuz makbuz = new frmMakbuz();
            makbuz.ShowDialog();
        }

        private void frmAboneGorevEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
