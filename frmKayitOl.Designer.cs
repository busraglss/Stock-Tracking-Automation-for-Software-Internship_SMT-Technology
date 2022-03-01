namespace StockTrackingAutomation
{
    partial class frmKayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKayitOl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKayitgoster = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHesapEkle = new System.Windows.Forms.ComboBox();
            this.btnGeriCik = new System.Windows.Forms.Button();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.txtParolaEkle = new System.Windows.Forms.TextBox();
            this.txtKullaniciEkle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnKayitSil);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnKayitgoster);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbCinsiyet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbHesapEkle);
            this.panel1.Controls.Add(this.btnGeriCik);
            this.panel1.Controls.Add(this.btnKayitEkle);
            this.panel1.Controls.Add(this.txtParolaEkle);
            this.panel1.Controls.Add(this.txtKullaniciEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 603);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitSil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKayitSil.Location = new System.Drawing.Point(601, 486);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(111, 29);
            this.btnKayitSil.TabIndex = 7;
            this.btnKayitSil.Text = "Kaydı Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 343);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnKayitgoster
            // 
            this.btnKayitgoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitgoster.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKayitgoster.Location = new System.Drawing.Point(718, 486);
            this.btnKayitgoster.Name = "btnKayitgoster";
            this.btnKayitgoster.Size = new System.Drawing.Size(163, 29);
            this.btnKayitgoster.TabIndex = 5;
            this.btnKayitgoster.Text = "Kayıtlı kullanıcıları göster";
            this.btnKayitgoster.UseVisualStyleBackColor = true;
            this.btnKayitgoster.Click += new System.EventHandler(this.btnKayitgoster_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(71, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cinsiyet :";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(193, 287);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(166, 21);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(71, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hesap türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(71, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(71, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı adı :";
            // 
            // cmbHesapEkle
            // 
            this.cmbHesapEkle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHesapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHesapEkle.FormattingEnabled = true;
            this.cmbHesapEkle.Location = new System.Drawing.Point(193, 230);
            this.cmbHesapEkle.Name = "cmbHesapEkle";
            this.cmbHesapEkle.Size = new System.Drawing.Size(166, 21);
            this.cmbHesapEkle.TabIndex = 2;
            // 
            // btnGeriCik
            // 
            this.btnGeriCik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriCik.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGeriCik.Location = new System.Drawing.Point(918, 548);
            this.btnGeriCik.Name = "btnGeriCik";
            this.btnGeriCik.Size = new System.Drawing.Size(115, 24);
            this.btnGeriCik.TabIndex = 6;
            this.btnGeriCik.Text = "Geri çık";
            this.btnGeriCik.UseVisualStyleBackColor = true;
            this.btnGeriCik.Click += new System.EventHandler(this.btnGeriCik_Click);
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKayitEkle.Location = new System.Drawing.Point(248, 371);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(111, 29);
            this.btnKayitEkle.TabIndex = 4;
            this.btnKayitEkle.Text = "Kaydı Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // txtParolaEkle
            // 
            this.txtParolaEkle.Location = new System.Drawing.Point(193, 171);
            this.txtParolaEkle.Name = "txtParolaEkle";
            this.txtParolaEkle.Size = new System.Drawing.Size(166, 20);
            this.txtParolaEkle.TabIndex = 1;
            // 
            // txtKullaniciEkle
            // 
            this.txtKullaniciEkle.Location = new System.Drawing.Point(193, 113);
            this.txtKullaniciEkle.Name = "txtKullaniciEkle";
            this.txtKullaniciEkle.Size = new System.Drawing.Size(166, 20);
            this.txtKullaniciEkle.TabIndex = 0;
            // 
            // frmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Oluştur";
            this.Load += new System.EventHandler(this.frmKayitOl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHesapEkle;
        private System.Windows.Forms.Button btnGeriCik;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.TextBox txtParolaEkle;
        private System.Windows.Forms.TextBox txtKullaniciEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button btnKayitgoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKayitSil;
    }
}