﻿
namespace GDApplication
{
    partial class KayıtOlForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(434, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAYIT OL";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(138, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 45);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Kullanıcı Adı";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.Color.LightGray;
            this.txtEmail.Location = new System.Drawing.Point(138, 339);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 45);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "E-Mail";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtIlce
            // 
            this.txtIlce.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlce.ForeColor = System.Drawing.Color.LightGray;
            this.txtIlce.Location = new System.Drawing.Point(634, 248);
            this.txtIlce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIlce.Multiline = true;
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(295, 45);
            this.txtIlce.TabIndex = 3;
            this.txtIlce.Text = "İlçe";
            this.txtIlce.Enter += new System.EventHandler(this.txtİlce_Enter);
            this.txtIlce.Leave += new System.EventHandler(this.txtİlce_Leave);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogumTarihi.ForeColor = System.Drawing.Color.LightGray;
            this.txtDogumTarihi.Location = new System.Drawing.Point(634, 125);
            this.txtDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDogumTarihi.Multiline = true;
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(295, 45);
            this.txtDogumTarihi.TabIndex = 4;
            this.txtDogumTarihi.Text = "Doğum Tarihi";
            this.txtDogumTarihi.Enter += new System.EventHandler(this.txtDogumTarihi_Enter);
            this.txtDogumTarihi.Leave += new System.EventHandler(this.txtDogumTarihi_Leave);
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.ForeColor = System.Drawing.Color.LightGray;
            this.txtTcNo.Location = new System.Drawing.Point(138, 393);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTcNo.Multiline = true;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(295, 45);
            this.txtTcNo.TabIndex = 5;
            this.txtTcNo.Text = "TC No";
            this.txtTcNo.Enter += new System.EventHandler(this.txtTcNo_Enter);
            this.txtTcNo.Leave += new System.EventHandler(this.txtTcNo_Leave);
            // 
            // txtSehir
            // 
            this.txtSehir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSehir.ForeColor = System.Drawing.Color.LightGray;
            this.txtSehir.Location = new System.Drawing.Point(634, 194);
            this.txtSehir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSehir.Multiline = true;
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(295, 45);
            this.txtSehir.TabIndex = 6;
            this.txtSehir.Text = "Şehir";
            this.txtSehir.Enter += new System.EventHandler(this.txtSehir_Enter);
            this.txtSehir.Leave += new System.EventHandler(this.txtSehir_Leave);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.LightGray;
            this.txtSoyad.Location = new System.Drawing.Point(138, 286);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(295, 45);
            this.txtSoyad.TabIndex = 7;
            this.txtSoyad.Text = "Soyadınız";
            this.txtSoyad.Enter += new System.EventHandler(this.txtSoyad_Enter);
            this.txtSoyad.Leave += new System.EventHandler(this.txtSoyad_Leave);
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.ForeColor = System.Drawing.Color.LightGray;
            this.txtAdres.Location = new System.Drawing.Point(634, 301);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(295, 45);
            this.txtAdres.TabIndex = 8;
            this.txtAdres.Text = "Adres";
            this.txtAdres.Enter += new System.EventHandler(this.txtAdres_Enter);
            this.txtAdres.Leave += new System.EventHandler(this.txtAdres_Leave);
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.ForeColor = System.Drawing.Color.LightGray;
            this.txtTelNo.Location = new System.Drawing.Point(634, 355);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelNo.Multiline = true;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(295, 45);
            this.txtTelNo.TabIndex = 9;
            this.txtTelNo.Text = "Telefon Numarası";
            this.txtTelNo.Enter += new System.EventHandler(this.txtTelNo_Enter);
            this.txtTelNo.Leave += new System.EventHandler(this.txtTelNo_Leave);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.LightGray;
            this.txtAd.Location = new System.Drawing.Point(138, 232);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(295, 45);
            this.txtAd.TabIndex = 11;
            this.txtAd.Text = "Adınız";
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.LightGray;
            this.txtSifre.Location = new System.Drawing.Point(138, 178);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(295, 45);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCinsiyet.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(634, 409);
            this.comboBoxCinsiyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(295, 37);
            this.comboBoxCinsiyet.TabIndex = 13;
            this.comboBoxCinsiyet.Text = "Cinsiyet";
            this.comboBoxCinsiyet.Enter += new System.EventHandler(this.comboBoxCinsiyet_Enter);
            this.comboBoxCinsiyet.Leave += new System.EventHandler(this.comboBoxCinsiyet_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(443, 493);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 68);
            this.button1.TabIndex = 14;
            this.button1.Text = "KAYDOL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KayıtOlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::GDApplication.Properties.Resources.gazete;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KayıtOlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KayıtOlForm";
            this.Load += new System.EventHandler(this.KayıtOlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Button button1;
    }
}