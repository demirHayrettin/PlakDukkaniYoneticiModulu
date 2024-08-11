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
    public partial class EklenenSon10AlbumForm : Form
    {
        private AppDbContext _context;
        public EklenenSon10AlbumForm()
        {
            InitializeComponent();

            _context = new AppDbContext();
            SonEklenen10AlbumYukle();
        }

        private void SonEklenen10AlbumYukle()
        {
            dgvEKlenenSon10.DataSource = _context.Albumler.OrderByDescending(a => a.ID).Take(10).Select(a => new { a.AlbumAdi, a.Sanatci }).ToList();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
