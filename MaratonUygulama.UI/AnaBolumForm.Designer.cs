namespace MaratonUygulama.UI
{
    partial class AnaBolumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAlbumler = new DataGridView();
            grp1 = new GroupBox();
            btnAlbumEkle = new Button();
            btnAlbumGuncelle = new Button();
            btnALbumSil = new Button();
            btnIndirimliAlbumler = new Button();
            btn10Album = new Button();
            btnSatisiDevamEdenAlbumler = new Button();
            btnSatisiDurmusAlbumler = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).BeginInit();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAlbumler
            // 
            dgvAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumler.Location = new Point(21, 35);
            dgvAlbumler.Name = "dgvAlbumler";
            dgvAlbumler.Size = new Size(690, 440);
            dgvAlbumler.TabIndex = 0;
            // 
            // grp1
            // 
            grp1.Controls.Add(dgvAlbumler);
            grp1.Location = new Point(24, 12);
            grp1.Name = "grp1";
            grp1.Size = new Size(744, 520);
            grp1.TabIndex = 1;
            grp1.TabStop = false;
            grp1.Text = "ALBÜMLER";
            // 
            // btnAlbumEkle
            // 
            btnAlbumEkle.Location = new Point(824, 47);
            btnAlbumEkle.Name = "btnAlbumEkle";
            btnAlbumEkle.Size = new Size(126, 47);
            btnAlbumEkle.TabIndex = 2;
            btnAlbumEkle.Text = "ALBÜM EKLE";
            btnAlbumEkle.UseVisualStyleBackColor = true;
            btnAlbumEkle.Click += btnAlbumEkle_Click;
            // 
            // btnAlbumGuncelle
            // 
            btnAlbumGuncelle.Location = new Point(824, 117);
            btnAlbumGuncelle.Name = "btnAlbumGuncelle";
            btnAlbumGuncelle.Size = new Size(126, 49);
            btnAlbumGuncelle.TabIndex = 3;
            btnAlbumGuncelle.Text = "ALBÜM GÜNCELLE";
            btnAlbumGuncelle.UseVisualStyleBackColor = true;
            btnAlbumGuncelle.Click += btnAlbumGuncelle_Click;
            // 
            // btnALbumSil
            // 
            btnALbumSil.Location = new Point(824, 197);
            btnALbumSil.Name = "btnALbumSil";
            btnALbumSil.Size = new Size(126, 49);
            btnALbumSil.TabIndex = 4;
            btnALbumSil.Text = "ALBÜM SİL";
            btnALbumSil.UseVisualStyleBackColor = true;
            btnALbumSil.Click += btnALbumSil_Click;
            // 
            // btnIndirimliAlbumler
            // 
            btnIndirimliAlbumler.Location = new Point(45, 652);
            btnIndirimliAlbumler.Name = "btnIndirimliAlbumler";
            btnIndirimliAlbumler.Size = new Size(239, 59);
            btnIndirimliAlbumler.TabIndex = 5;
            btnIndirimliAlbumler.Text = "İndirimdeki Albümleri Göster";
            btnIndirimliAlbumler.UseVisualStyleBackColor = true;
            btnIndirimliAlbumler.Click += btnIndirimliAlbumler_Click;
            // 
            // btn10Album
            // 
            btn10Album.Location = new Point(418, 652);
            btn10Album.Name = "btn10Album";
            btn10Album.Size = new Size(236, 59);
            btn10Album.TabIndex = 7;
            btn10Album.Text = "Sisteme En Son Eklenen 10 Albümü Göster";
            btn10Album.UseVisualStyleBackColor = true;
            btn10Album.Click += btn10Album_Click;
            // 
            // btnSatisiDevamEdenAlbumler
            // 
            btnSatisiDevamEdenAlbumler.Location = new Point(418, 556);
            btnSatisiDevamEdenAlbumler.Name = "btnSatisiDevamEdenAlbumler";
            btnSatisiDevamEdenAlbumler.Size = new Size(236, 62);
            btnSatisiDevamEdenAlbumler.TabIndex = 8;
            btnSatisiDevamEdenAlbumler.Text = "Satışı Devam Eden Albümleri Göster";
            btnSatisiDevamEdenAlbumler.UseVisualStyleBackColor = true;
            btnSatisiDevamEdenAlbumler.Click += btnSatisiDevamEdenAlbumler_Click;
            // 
            // btnSatisiDurmusAlbumler
            // 
            btnSatisiDurmusAlbumler.Location = new Point(45, 556);
            btnSatisiDurmusAlbumler.Name = "btnSatisiDurmusAlbumler";
            btnSatisiDurmusAlbumler.Size = new Size(239, 62);
            btnSatisiDurmusAlbumler.TabIndex = 9;
            btnSatisiDurmusAlbumler.Text = "Satışı Durmuş Albümleri Göster";
            btnSatisiDurmusAlbumler.UseVisualStyleBackColor = true;
            btnSatisiDurmusAlbumler.Click += btnSatisiDurmusAlbumler_Click;
            // 
            // AnaBolumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 745);
            Controls.Add(btnSatisiDurmusAlbumler);
            Controls.Add(btnSatisiDevamEdenAlbumler);
            Controls.Add(btn10Album);
            Controls.Add(btnIndirimliAlbumler);
            Controls.Add(btnALbumSil);
            Controls.Add(btnAlbumGuncelle);
            Controls.Add(btnAlbumEkle);
            Controls.Add(grp1);
            Name = "AnaBolumForm";
            Text = "AnaBolumForm";
            Load += AnaBolumForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).EndInit();
            grp1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAlbumler;
        private GroupBox grp1;
        private Button btnAlbumEkle;
        private Button btnAlbumGuncelle;
        private Button btnALbumSil;
        private Button btnIndirimliAlbumler;
        private Button button1;
        private Button btn10Album;
        private Button btnSatisiDevamEdenAlbumler;
        private Button btnSatisiDurmusAlbumler;
    }
}