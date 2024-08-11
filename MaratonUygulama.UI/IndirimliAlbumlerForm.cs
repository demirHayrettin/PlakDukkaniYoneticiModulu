using Microsoft.EntityFrameworkCore;
using PlakDukkaniYoneticiModulu.DAL;
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
    public partial class IndirimliAlbumlerForm : Form
    {
        private AppDbContext _context;
        public IndirimliAlbumlerForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            IndirimliAlbumleriYukle();
        }

        private void IndirimliAlbumleriYukle()
        {
            dgvIndirimliler.DataSource = _context.Albumler.Where(a => a.IndirimOrani != null && a.IndirimOrani > 0)
                .OrderByDescending(a => a.IndirimOrani).Select(a => new { a.AlbumAdi, a.Sanatci }).ToList();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
