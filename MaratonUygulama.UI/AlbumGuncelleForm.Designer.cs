namespace MaratonUygulama.UI
{
    partial class AlbumGuncelleForm
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
            grp2 = new GroupBox();
            btnIptal = new Button();
            txtIndirimOrani = new TextBox();
            label6 = new Label();
            txtSanatci = new TextBox();
            label5 = new Label();
            txtFiyati = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbSatisDurumu = new ComboBox();
            label2 = new Label();
            dtpCikisTarihi = new DateTimePicker();
            txtAlbumAdi = new TextBox();
            label1 = new Label();
            btnGuncelle = new Button();
            grp2.SuspendLayout();
            SuspendLayout();
            // 
            // grp2
            // 
            grp2.Controls.Add(btnIptal);
            grp2.Controls.Add(txtIndirimOrani);
            grp2.Controls.Add(label6);
            grp2.Controls.Add(txtSanatci);
            grp2.Controls.Add(label5);
            grp2.Controls.Add(txtFiyati);
            grp2.Controls.Add(label4);
            grp2.Controls.Add(label3);
            grp2.Controls.Add(cmbSatisDurumu);
            grp2.Controls.Add(label2);
            grp2.Controls.Add(dtpCikisTarihi);
            grp2.Controls.Add(txtAlbumAdi);
            grp2.Controls.Add(label1);
            grp2.Controls.Add(btnGuncelle);
            grp2.Location = new Point(31, 12);
            grp2.Name = "grp2";
            grp2.Size = new Size(708, 416);
            grp2.TabIndex = 0;
            grp2.TabStop = false;
            grp2.Text = "ALBÜM GÜNCELLEME";
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(218, 332);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 46);
            btnIptal.TabIndex = 13;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // txtIndirimOrani
            // 
            txtIndirimOrani.Location = new Point(233, 226);
            txtIndirimOrani.Name = "txtIndirimOrani";
            txtIndirimOrani.Size = new Size(200, 23);
            txtIndirimOrani.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 226);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 11;
            label6.Text = "İndirim Oranı (Varsa):";
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(233, 284);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(200, 23);
            txtSanatci.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 288);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Sanatçısı:";
            // 
            // txtFiyati
            // 
            txtFiyati.Location = new Point(233, 192);
            txtFiyati.Name = "txtFiyati";
            txtFiyati.Size = new Size(200, 23);
            txtFiyati.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 192);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Fiyatı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 255);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Satış Durumu:";
            // 
            // cmbSatisDurumu
            // 
            cmbSatisDurumu.FormattingEnabled = true;
            cmbSatisDurumu.Location = new Point(233, 255);
            cmbSatisDurumu.Name = "cmbSatisDurumu";
            cmbSatisDurumu.Size = new Size(200, 23);
            cmbSatisDurumu.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 155);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Çıkış Tarihi:";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(233, 150);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(200, 23);
            dtpCikisTarihi.TabIndex = 3;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(233, 105);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(200, 23);
            txtAlbumAdi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 105);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Albüm Adı:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(316, 332);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(117, 46);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "ALBÜMÜ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // AlbumGuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grp2);
            Name = "AlbumGuncelleForm";
            Text = "AlbumGuncelleForm";
            Load += AlbumGuncelleForm_Load;
            grp2.ResumeLayout(false);
            grp2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp2;
        private TextBox txtAlbumAdi;
        private Label label1;
        private Button btnGuncelle;
        private ComboBox cmbSatisDurumu;
        private Label label2;
        private DateTimePicker dtpCikisTarihi;
        private Label label3;
        private TextBox txtSanatci;
        private Label label5;
        private TextBox txtFiyati;
        private Label label4;
        private TextBox txtIndirimOrani;
        private Label label6;
        private Button btnIptal;
    }
}