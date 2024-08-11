using PlakDukkaniYoneticiModulu.DAL;
using PlakDukkaniYoneticiModulu.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaratonUygulama.UI
{
    public partial class AlbumGuncelleForm : Form
    {
        private AppDbContext _context;
        private int albumId;
        public AlbumGuncelleForm(int albumId)
        {
            InitializeComponent();

            _context = new AppDbContext();
            this.albumId = albumId;
        }


        private void AlbumGuncelleForm_Load(object sender, EventArgs e)
        {
            cmbSatisDurumu.DataSource = Enum.GetValues(typeof(SatisDurumu))
                .Cast<SatisDurumu>()
                .Select(e => new { Value = (int)e, Name = GetEnumDisplayName(e) })
                .ToList();
            cmbSatisDurumu.DisplayMember = "Name";
            cmbSatisDurumu.ValueMember = "Value";

            Album mevcutAlbum = _context.Albumler.Find(albumId);
            if (mevcutAlbum != null)
            {
                txtAlbumAdi.Text = mevcutAlbum.AlbumAdi;
                dtpCikisTarihi.Value = mevcutAlbum.CikisTarihi;
                txtFiyati.Text = mevcutAlbum.Fiyati.ToString();
                txtIndirimOrani.Text = mevcutAlbum.IndirimOrani?.ToString();
                cmbSatisDurumu.SelectedValue = (int)mevcutAlbum.SatisDurumu;
                txtSanatci.Text = mevcutAlbum.Sanatci.ToString();
            }
            else
            {
                MessageBox.Show("Albüm bulunmadı.");
            }
        }

        private string GetEnumDisplayName(SatisDurumu satisDurumu)
        {
            var displayAttribute = satisDurumu.GetType()
                .GetField(satisDurumu.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .FirstOrDefault() as DisplayAttribute;

            return displayAttribute != null ? displayAttribute.Name : satisDurumu.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Album guncellenenAlbum = _context.Albumler.Find(albumId);

            if(guncellenenAlbum != null)
            {
                guncellenenAlbum.AlbumAdi = txtAlbumAdi.Text.Trim() ;
                guncellenenAlbum.CikisTarihi = dtpCikisTarihi.Value;
                guncellenenAlbum.Fiyati = decimal.Parse(txtFiyati.Text.Trim());
                guncellenenAlbum.IndirimOrani = string.IsNullOrWhiteSpace(txtIndirimOrani.Text) ? (int?)null : int.Parse(txtIndirimOrani.Text);
                guncellenenAlbum.SatisDurumu = (SatisDurumu)cmbSatisDurumu.SelectedValue;
                guncellenenAlbum.Sanatci = txtSanatci.Text.Trim();

                _context.SaveChanges();



                MessageBox.Show("Albüm başarıyla güncellendi.");
                this.Close();

                AnaBolumForm frm = new AnaBolumForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Albüm bulunamadı");
                
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

        }
    }
}
