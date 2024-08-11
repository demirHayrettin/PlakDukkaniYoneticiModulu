using PlakDukkaniYoneticiModulu.DAL;
using System.Security.Cryptography;
using System.Text;

namespace MaratonUygulama.UI
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;

        public Form1()
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var admin = _context.Adminler.FirstOrDefault(a => a.KullaniciAdi == txtKullaniciAdi.Text.Trim());

            if (admin != null)
            {
                string hashedsifre = sha256_hash(txtSifre.Text.Trim());

                if (admin.Sifre == hashedsifre)
                {
                    MessageBox.Show("Y�netici giri�i ba�ar�l�!");

                    
                    AnaBolumForm form = new AnaBolumForm();
                    form.Show();
                    
                }
                else
                {
                    MessageBox.Show("�ifre Hatal�. Tekrar deneyin.");

                }
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� bulunamad�.");
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kay�tForm kayitForm = new Kay�tForm();
            kayitForm.ShowDialog();
        }
    }
}
