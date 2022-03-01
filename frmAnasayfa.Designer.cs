namespace StockTrackingAutomation
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAktifGirisAnasyf = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnStokKontrol = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtAktifGirisAnasyf);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnUrunEkle);
            this.panel1.Controls.Add(this.btnUrunGuncelle);
            this.panel1.Controls.Add(this.btnStokKontrol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 609);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(690, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Kullanıcı :";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAktifGirisAnasyf
            // 
            this.txtAktifGirisAnasyf.Location = new System.Drawing.Point(764, 0);
            this.txtAktifGirisAnasyf.Name = "txtAktifGirisAnasyf";
            this.txtAktifGirisAnasyf.ReadOnly = true;
            this.txtAktifGirisAnasyf.Size = new System.Drawing.Size(92, 20);
            this.txtAktifGirisAnasyf.TabIndex = 13;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(687, 555);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(92, 28);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Geri Dön";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunEkle.Location = new System.Drawing.Point(478, 313);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(239, 106);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(478, 179);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(239, 106);
            this.btnUrunGuncelle.TabIndex = 1;
            this.btnUrunGuncelle.Text = "Ürün güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnStokKontrol
            // 
            this.btnStokKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStokKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStokKontrol.Location = new System.Drawing.Point(478, 53);
            this.btnStokKontrol.Name = "btnStokKontrol";
            this.btnStokKontrol.Size = new System.Drawing.Size(239, 106);
            this.btnStokKontrol.TabIndex = 0;
            this.btnStokKontrol.Text = "Stok Kontrol";
            this.btnStokKontrol.UseVisualStyleBackColor = true;
            this.btnStokKontrol.Click += new System.EventHandler(this.btnStokKontrol_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 609);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnasayfa_FormClosing);
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnStokKontrol;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox txtAktifGirisAnasyf;
    }
}

