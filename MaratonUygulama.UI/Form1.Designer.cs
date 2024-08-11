namespace MaratonUygulama.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnKayitOl = new Button();
            label3 = new Label();
            txtSifreKontrol = new TextBox();
            btnGiris = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKayitOl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSifreKontrol);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Location = new Point(33, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 327);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yönetici Giriş Bölümü";
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(199, 279);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(75, 23);
            btnKayitOl.TabIndex = 7;
            btnKayitOl.Text = "Kayıt Ol!";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 177);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Şifre Tekrarı:";
            // 
            // txtSifreKontrol
            // 
            txtSifreKontrol.Location = new Point(129, 177);
            txtSifreKontrol.Name = "txtSifreKontrol";
            txtSifreKontrol.Size = new Size(195, 23);
            txtSifreKontrol.TabIndex = 5;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(183, 222);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(91, 31);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 128);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 73);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(129, 128);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(195, 23);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(129, 70);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(195, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGiris;
        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtSifreKontrol;
        private Button btnKayitOl;
    }
}
