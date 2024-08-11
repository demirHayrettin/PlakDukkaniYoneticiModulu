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
    public partial class AnaBolumForm : Form
    {
        private AppDbContext _context;
        public AnaBolumForm()
        {
            InitializeComponent();
            _context = new AppDbContext();

            AlbumleriYuke();
        }

        public void AlbumleriYuke()
        {
            dgvAlbumler.DataSource = _context.Albumler.Select(a => new {a.ID, a.AlbumAdi, a.CikisTarihi, a.Fiyati, a.IndirimOrani, a.Sanatci, a.SatisDurumu}).ToList();
        }

        private void AnaBolumForm_Load(object sender, EventArgs e)
        {
            AlbumleriYuke();
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {
            AlbumEkleForm albumEkle = new AlbumEkleForm();
            albumEkle.ShowDialog();

            AlbumleriYuke();
        }

        private void btnAlbumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvAlbumler.SelectedRows.Count > 0)
            {
                int albumId = Convert.ToInt32(dgvAlbumler.SelectedRows[0].Cells["ID"].Value);
                AlbumGuncelleForm albumGuncelle = new AlbumGuncelleForm(albumId);
                albumGuncelle.ShowDialog();
                this.Close();

                AlbumleriYuke();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir albüm seçiniz.");
            }


        }

        private void btnALbumSil_Click(object sender, EventArgs e)
        {
            if (dgvAlbumler.SelectedRows.Count > 0)
            {
                int albumId = Convert.ToInt32(dgvAlbumler.SelectedRows[0].Cells["ID"].Value);

                Album silinecekAlbum = _context.Albumler.Find(albumId);

                if (silinecekAlbum != null)
                {
                    _context.Albumler.Remove(silinecekAlbum);
                    _context.SaveChanges();

                    MessageBox.Show("Albüm başarılı bir şekilde silindi.");

                    AlbumleriYuke();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek albümü seçiniz.");
            }
        }

        private void btnSatisiDurmusAlbumler_Click(object sender, EventArgs e)
        {
            SatisiDurmusAlbumlerForm frm = new SatisiDurmusAlbumlerForm();
            frm.Show();
        }

        private void btnSatisiDevamEdenAlbumler_Click(object sender, EventArgs e)
        {
            SatisiDevamEdenAlbumlerForm frm = new SatisiDevamEdenAlbumlerForm();
            frm.Show();
        }

        private void btnIndirimliAlbumler_Click(object sender, EventArgs e)
        {
            IndirimliAlbumlerForm frm = new IndirimliAlbumlerForm();
            frm.Show();
        }

        private void btn10Album_Click(object sender, EventArgs e)
        {
            EklenenSon10AlbumForm frm = new EklenenSon10AlbumForm();
            frm.Show();
        }
    }
}
