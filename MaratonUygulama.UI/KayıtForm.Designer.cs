namespace MaratonUygulama.UI
{
    partial class KayıtForm
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
            label3 = new Label();
            txtSifreKontrol = new TextBox();
            btnKayitOl = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label4 = new Label();
            txtAdi = new TextBox();
            label5 = new Label();
            txtSoyadi = new TextBox();
            btnGirisEkraninaDon = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 256);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 13;
            label3.Text = "Şifre Tekrarı:";
            // 
            // txtSifreKontrol
            // 
            txtSifreKontrol.Location = new Point(223, 256);
            txtSifreKontrol.Name = "txtSifreKontrol";
            txtSifreKontrol.Size = new Size(195, 23);
            txtSifreKontrol.TabIndex = 12;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(277, 301);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(91, 31);
            btnKayitOl.TabIndex = 11;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 207);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 10;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 152);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(223, 207);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(195, 23);
            txtSifre.TabIndex = 8;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(223, 149);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(195, 23);
            txtKullaniciAdi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 57);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 15;
            label4.Text = "Adı:";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(223, 57);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(195, 23);
            txtAdi.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 105);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 17;
            label5.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(223, 102);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(195, 23);
            txtSoyadi.TabIndex = 16;
            // 
            // btnGirisEkraninaDon
            // 
            btnGirisEkraninaDon.Location = new Point(208, 368);
            btnGirisEkraninaDon.Name = "btnGirisEkraninaDon";
            btnGirisEkraninaDon.Size = new Size(223, 23);
            btnGirisEkraninaDon.TabIndex = 18;
            btnGirisEkraninaDon.Text = "Giriş Ekranına Dön!";
            btnGirisEkraninaDon.UseVisualStyleBackColor = true;
            btnGirisEkraninaDon.Click += btnGirisEkraninaDon_Click;
            // 
            // KayıtForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGirisEkraninaDon);
            Controls.Add(label5);
            Controls.Add(txtSoyadi);
            Controls.Add(label4);
            Controls.Add(txtAdi);
            Controls.Add(label3);
            Controls.Add(txtSifreKontrol);
            Controls.Add(btnKayitOl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "KayıtForm";
            Text = "KayıtForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtSifreKontrol;
        private Button btnKayitOl;
        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label4;
        private TextBox txtAdi;
        private Label label5;
        private TextBox txtSoyadi;
        private Button btnGirisEkraninaDon;
    }
}