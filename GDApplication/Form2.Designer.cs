
namespace GDApplication
{
    partial class frmAboneGorevEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboneGorevEkrani));
            this.btnHesapAyarlari = new System.Windows.Forms.Button();
            this.btnMakbuzGoruntule = new System.Windows.Forms.Button();
            this.btnYardim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHesapAyarlari
            // 
            this.btnHesapAyarlari.BackColor = System.Drawing.Color.SandyBrown;
            this.btnHesapAyarlari.Location = new System.Drawing.Point(121, 97);
            this.btnHesapAyarlari.Name = "btnHesapAyarlari";
            this.btnHesapAyarlari.Size = new System.Drawing.Size(149, 59);
            this.btnHesapAyarlari.TabIndex = 0;
            this.btnHesapAyarlari.Text = "Hesap Ayarları";
            this.btnHesapAyarlari.UseVisualStyleBackColor = false;
            this.btnHesapAyarlari.Click += new System.EventHandler(this.btnHesapAyarlari_Click);
            // 
            // btnMakbuzGoruntule
            // 
            this.btnMakbuzGoruntule.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMakbuzGoruntule.Location = new System.Drawing.Point(121, 182);
            this.btnMakbuzGoruntule.Name = "btnMakbuzGoruntule";
            this.btnMakbuzGoruntule.Size = new System.Drawing.Size(149, 54);
            this.btnMakbuzGoruntule.TabIndex = 1;
            this.btnMakbuzGoruntule.Text = "Makbuz Görüntüle";
            this.btnMakbuzGoruntule.UseVisualStyleBackColor = false;
            this.btnMakbuzGoruntule.Click += new System.EventHandler(this.btnMakbuzGoruntule_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.BackColor = System.Drawing.Color.SandyBrown;
            this.btnYardim.Location = new System.Drawing.Point(121, 264);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(149, 50);
            this.btnYardim.TabIndex = 2;
            this.btnYardim.Text = "Yardım";
            this.btnYardim.UseVisualStyleBackColor = false;
            // 
            // frmAboneGorevEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(416, 424);
            this.Controls.Add(this.btnYardim);
            this.Controls.Add(this.btnMakbuzGoruntule);
            this.Controls.Add(this.btnHesapAyarlari);
            this.Name = "frmAboneGorevEkrani";
            this.Text = "Abone Görev Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesapAyarlari;
        private System.Windows.Forms.Button btnMakbuzGoruntule;
        private System.Windows.Forms.Button btnYardim;
    }
}