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

    public partial class AlbumEkleForm : Form
    {
        private AppDbContext _context;
        public AlbumEkleForm()
        {
            InitializeComponent();

            _context = new AppDbContext();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlbumAdi.Text) || string.IsNullOrEmpty(txtSanatci.Text))
            {
                MessageBox.Show("Albüm adı ve sanatcçı ismi zorunludur.");
                return;
            }

            Album yeniAlbum = new Album()
            {
                AlbumAdi = txtAlbumAdi.Text.Trim(),
                CikisTarihi = dtpCikisTarihi.Value,
                Fiyati = decimal.Parse(txtFiyati.Text),
                IndirimOrani = string.IsNullOrWhiteSpace(txtIndirimOrani.Text) ? (int?)null : int.Parse(txtIndirimOrani.Text),
                SatisDurumu = (SatisDurumu)cmbSatisDurumu.SelectedValue,
                Sanatci = txtSanatci.Text.Trim()

            };

            _context.Albumler.Add(yeniAlbum);
            _context.SaveChanges();

            MessageBox.Show("Albüm başarılı bir şekilde eklendi.");

            this.Close();
        }

        private void AlbumEkleForm_Load(object sender, EventArgs e)
        {
            cmbSatisDurumu.DataSource = Enum.GetValues(typeof(SatisDurumu))
                .Cast<SatisDurumu>()
                .Select(e => new { Value = (int)e, Name = GetEnumDisplayName(e) })
                .ToList();
            cmbSatisDurumu.DisplayMember = "Name";
            cmbSatisDurumu.ValueMember = "Value";
        }
        private string GetEnumDisplayName(SatisDurumu satisDurumu)
        {
            var displayAttribute = satisDurumu.GetType()
                .GetField(satisDurumu.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .FirstOrDefault() as DisplayAttribute;

            return displayAttribute != null ? displayAttribute.Name : satisDurumu.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
