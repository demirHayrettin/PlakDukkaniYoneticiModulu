using PlakDukkaniYoneticiModulu.DAL;
using PlakDukkaniYoneticiModulu.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaratonUygulama.UI
{
    public partial class KayıtForm : Form
    {
        private AppDbContext _context;
        public KayıtForm()
        {
            InitializeComponent();

            _context = new AppDbContext();
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            var admin = _context.Adminler.FirstOrDefault(a => a.KullaniciAdi == txtKullaniciAdi.Text.Trim());

            if (admin != null)
            {
                MessageBox.Show("Kullanıcı adı kayıtlıdır. Lütfen farklı bir kullanıcı adı giriniz.");
                return;
            }

            bool sifreKontrol = SifreKontrolEt(txtSifre.Text.Trim());

            if (!sifreKontrol)
            {
                MessageBox.Show("Şifre en az 8 karakter uzunluğunda olmalı, içinde en az 2 büyük harf, 3 küçük harf ve !, :, +, * gibi en az 2 özel karakter bulunmalı.");
                return;
            }

            if (txtSifre.Text.Trim() != txtSifreKontrol.Text.Trim())
            {
                MessageBox.Show("Şifreler eşleşmiyor. Lütfen şifrenizi yeniden giriniz.");
                return;
            }

            string hashedSifre = sha256_hash(txtSifre.Text.Trim());

            Admin yeniAdmin = new Admin()
            {
                Adi = txtAdi.Text.Trim(),
                Soyadi = txtSoyadi.Text.Trim(),
                KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                Sifre = hashedSifre,
                SifreKontrol = null

            };

            _context.Adminler.Add(yeniAdmin);
            _context.SaveChanges();

            MessageBox.Show("Yönetici başarılı bir şekilde kaydedildi.");
        }

        private bool SifreKontrolEt(string sifre)
        {
            return sifre.Length >= 8 && sifre.Count(char.IsUpper) >= 2 && sifre.Count(char.IsLower) >= 3 && sifre.Count(c => "!:+*".Contains(c)) >= 2;
        }

        private void btnGirisEkraninaDon_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
