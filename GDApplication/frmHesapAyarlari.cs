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
    public partial class frmHesapAyarlari : Form
    {
        public frmHesapAyarlari()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmAboneKayit AboneKayit = new frmAboneKayit();
            AboneKayit.ShowDialog();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            frmSifreGuncelleme frmSifreGuncelleme2 = new frmSifreGuncelleme();
            frmSifreGuncelleme2.ShowDialog();
        }
    }
}
