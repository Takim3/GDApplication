﻿using System;
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
    public partial class AboneGörevSecim : Form
    {
        public AboneGörevSecim()
        {
            InitializeComponent();
        }

        private void AboneGörevSecim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdminGazeteDüzenle düzenle = new frmAdminGazeteDüzenle();
            düzenle.ShowDialog();
        }
    }
}
