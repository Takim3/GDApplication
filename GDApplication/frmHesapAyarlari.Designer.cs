
namespace GDApplication
{
    partial class frmHesapAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapAyarlari));
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.btnKayitDuzenle = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSifreDegistir.Location = new System.Drawing.Point(120, 90);
            this.btnSifreDegistir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(118, 45);
            this.btnSifreDegistir.TabIndex = 0;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = false;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.BackColor = System.Drawing.Color.SandyBrown;
            this.btnKayitDuzenle.Location = new System.Drawing.Point(120, 154);
            this.btnKayitDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(118, 49);
            this.btnKayitDuzenle.TabIndex = 1;
            this.btnKayitDuzenle.Text = "Kayıt Düzenle";
            this.btnKayitDuzenle.UseVisualStyleBackColor = false;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.SandyBrown;
            this.btnKayitOl.Location = new System.Drawing.Point(120, 217);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(118, 42);
            this.btnKayitOl.TabIndex = 2;
            this.btnKayitOl.Text = "Yeni Kayıt";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // frmHesapAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 346);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnKayitDuzenle);
            this.Controls.Add(this.btnSifreDegistir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHesapAyarlari";
            this.Text = "Hesap Ayarlari";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Button btnKayitDuzenle;
        private System.Windows.Forms.Button btnKayitOl;
    }
}