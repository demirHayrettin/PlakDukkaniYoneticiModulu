using PlakDukkaniYoneticiModulu.DAL;
using PlakDukkaniYoneticiModulu.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaratonUygulama.UI
{
    public partial class SatisiDevamEdenAlbumlerForm : Form
    {
        private AppDbContext _context;

        public SatisiDevamEdenAlbumlerForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            SatisiDevamEdenAlbumleriYukle();
        }

        private void SatisiDevamEdenAlbumleriYukle()
        {
            dgvSatisiDevamEdenler.DataSource = _context.Albumler.Where(a => a.SatisDurumu == SatisDurumu.DevamEdiyor).Select(a => new { a.AlbumAdi, a.Sanatci }).ToList();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
