namespace MaratonUygulama.UI
{
    partial class IndirimliAlbumlerForm
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
            groupBox1 = new GroupBox();
            btnKapat = new Button();
            dgvIndirimliler = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIndirimliler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKapat);
            groupBox1.Controls.Add(dgvIndirimliler);
            groupBox1.Location = new Point(48, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 416);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "İndirimli Albümler";
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
            // dgvIndirimliler
            // 
            dgvIndirimliler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIndirimliler.Location = new Point(6, 22);
            dgvIndirimliler.Name = "dgvIndirimliler";
            dgvIndirimliler.Size = new Size(557, 388);
            dgvIndirimliler.TabIndex = 0;
            // 
            // IndirimliAlbumlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "IndirimliAlbumlerForm";
            Text = "IndirimliAlbumlerForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIndirimliler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKapat;
        private DataGridView dgvIndirimliler;
    }
}