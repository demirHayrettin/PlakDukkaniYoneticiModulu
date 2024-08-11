namespace MaratonUygulama.UI
{
    partial class SatisiDevamEdenAlbumlerForm
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
            dgvSatisiDevamEdenler = new DataGridView();
            groupBox1 = new GroupBox();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDevamEdenler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSatisiDevamEdenler
            // 
            dgvSatisiDevamEdenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatisiDevamEdenler.Location = new Point(6, 22);
            dgvSatisiDevamEdenler.Name = "dgvSatisiDevamEdenler";
            dgvSatisiDevamEdenler.Size = new Size(557, 388);
            dgvSatisiDevamEdenler.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKapat);
            groupBox1.Controls.Add(dgvSatisiDevamEdenler);
            groupBox1.Location = new Point(53, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 416);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Satışı Devam Eden Albümler";
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(599, 38);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 23);
            btnKapat.TabIndex = 1;
            btnKapat.Text = "KAPAT";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // SatisiDevamEdenAlbumlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(groupBox1);
            Name = "SatisiDevamEdenAlbumlerForm";
            Text = "SatisiDevamEdenAlbumlerForm";
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDevamEdenler).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSatisiDevamEdenler;
        private GroupBox groupBox1;
        private Button btnKapat;
    }
}