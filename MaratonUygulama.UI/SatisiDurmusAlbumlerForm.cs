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
    public partial class SatisiDurmusAlbumlerForm : Form
    {
        private AppDbContext _context;
        public SatisiDurmusAlbumlerForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            SatisiDuranAlbumleriYukle();
        }





        private void SatisiDuranAlbumleriYukle()
        {
            dgvSatisiDurmuslar.DataSource = _context.Albumler.Where(a => a.SatisDurumu == SatisDurumu.SatisDurduruldu).Select(a => new { a.AlbumAdi, a.Sanatci }).ToList();
        }

      

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
