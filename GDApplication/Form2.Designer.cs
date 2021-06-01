
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
            this.btnHesapAyarlari.BackColor = System.Drawing.Color.Gray;
            this.btnHesapAyarlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAyarlari.Location = new System.Drawing.Point(418, 119);
            this.btnHesapAyarlari.Name = "btnHesapAyarlari";
            this.btnHesapAyarlari.Size = new System.Drawing.Size(173, 95);
            this.btnHesapAyarlari.TabIndex = 0;
            this.btnHesapAyarlari.Text = "Hesap Ayarları";
            this.btnHesapAyarlari.UseVisualStyleBackColor = false;
            this.btnHesapAyarlari.Click += new System.EventHandler(this.btnHesapAyarlari_Click);
            // 
            // btnMakbuzGoruntule
            // 
            this.btnMakbuzGoruntule.BackColor = System.Drawing.Color.Gray;
            this.btnMakbuzGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMakbuzGoruntule.Location = new System.Drawing.Point(418, 244);
            this.btnMakbuzGoruntule.Name = "btnMakbuzGoruntule";
            this.btnMakbuzGoruntule.Size = new System.Drawing.Size(173, 90);
            this.btnMakbuzGoruntule.TabIndex = 1;
            this.btnMakbuzGoruntule.Text = "Makbuz Görüntüle";
            this.btnMakbuzGoruntule.UseVisualStyleBackColor = false;
            this.btnMakbuzGoruntule.Click += new System.EventHandler(this.btnMakbuzGoruntule_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.BackColor = System.Drawing.Color.Gray;
            this.btnYardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYardim.Location = new System.Drawing.Point(418, 358);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(173, 86);
            this.btnYardim.TabIndex = 2;
            this.btnYardim.Text = "Yardım";
            this.btnYardim.UseVisualStyleBackColor = false;
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // frmAboneGorevEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 544);
            this.Controls.Add(this.btnYardim);
            this.Controls.Add(this.btnMakbuzGoruntule);
            this.Controls.Add(this.btnHesapAyarlari);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAboneGorevEkrani";
            this.Text = "Abone Görev Ekranı";
            this.Load += new System.EventHandler(this.frmAboneGorevEkrani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesapAyarlari;
        private System.Windows.Forms.Button btnMakbuzGoruntule;
        private System.Windows.Forms.Button btnYardim;
    }
}