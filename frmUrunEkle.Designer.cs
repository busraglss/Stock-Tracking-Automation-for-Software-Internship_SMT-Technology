namespace StockTrackingAutomation
{
    partial class frmUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPakettipiEkle = new System.Windows.Forms.TextBox();
            this.txtKategoriEkle = new System.Windows.Forms.TextBox();
            this.txtMiktarEkle = new System.Windows.Forms.TextBox();
            this.txtUruntanimiEkle = new System.Windows.Forms.TextBox();
            this.txtUrunadiEkle = new System.Windows.Forms.TextBox();
            this.txtUrunkilifiEkle = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGericik = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnGericik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 834);
            this.panel1.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(516, 600);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenile.Location = new System.Drawing.Point(611, 600);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 206);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(59, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 29);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtPakettipiEkle);
            this.panel2.Controls.Add(this.txtKategoriEkle);
            this.panel2.Controls.Add(this.txtMiktarEkle);
            this.panel2.Controls.Add(this.txtUruntanimiEkle);
            this.panel2.Controls.Add(this.txtUrunadiEkle);
            this.panel2.Controls.Add(this.txtUrunkilifiEkle);
            this.panel2.Controls.Add(this.btnUrunEkle);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(39, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 293);
            this.panel2.TabIndex = 4;
            // 
            // txtPakettipiEkle
            // 
            this.txtPakettipiEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPakettipiEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPakettipiEkle.Location = new System.Drawing.Point(201, 187);
            this.txtPakettipiEkle.Name = "txtPakettipiEkle";
            this.txtPakettipiEkle.Size = new System.Drawing.Size(166, 20);
            this.txtPakettipiEkle.TabIndex = 2;
            // 
            // txtKategoriEkle
            // 
            this.txtKategoriEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKategoriEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtKategoriEkle.Location = new System.Drawing.Point(507, 69);
            this.txtKategoriEkle.Name = "txtKategoriEkle";
            this.txtKategoriEkle.Size = new System.Drawing.Size(166, 20);
            this.txtKategoriEkle.TabIndex = 3;
            // 
            // txtMiktarEkle
            // 
            this.txtMiktarEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMiktarEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMiktarEkle.Location = new System.Drawing.Point(507, 187);
            this.txtMiktarEkle.Name = "txtMiktarEkle";
            this.txtMiktarEkle.Size = new System.Drawing.Size(166, 20);
            this.txtMiktarEkle.TabIndex = 5;
            // 
            // txtUruntanimiEkle
            // 
            this.txtUruntanimiEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUruntanimiEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUruntanimiEkle.Location = new System.Drawing.Point(507, 125);
            this.txtUruntanimiEkle.Name = "txtUruntanimiEkle";
            this.txtUruntanimiEkle.Size = new System.Drawing.Size(166, 20);
            this.txtUruntanimiEkle.TabIndex = 4;
            // 
            // txtUrunadiEkle
            // 
            this.txtUrunadiEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUrunadiEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUrunadiEkle.Location = new System.Drawing.Point(201, 130);
            this.txtUrunadiEkle.Name = "txtUrunadiEkle";
            this.txtUrunadiEkle.Size = new System.Drawing.Size(166, 20);
            this.txtUrunadiEkle.TabIndex = 1;
            // 
            // txtUrunkilifiEkle
            // 
            this.txtUrunkilifiEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUrunkilifiEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUrunkilifiEkle.Location = new System.Drawing.Point(201, 70);
            this.txtUrunkilifiEkle.Name = "txtUrunkilifiEkle";
            this.txtUrunkilifiEkle.Size = new System.Drawing.Size(166, 20);
            this.txtUrunkilifiEkle.TabIndex = 0;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUrunEkle.Location = new System.Drawing.Point(593, 243);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(80, 28);
            this.btnUrunEkle.TabIndex = 6;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(406, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ürün miktarı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(406, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ürün tanımı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(406, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Paket tipi (THT,SMD) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ürün adı (10K,220NF) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün kılıfı (0805,CAP20) :";
            // 
            // btnGericik
            // 
            this.btnGericik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGericik.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGericik.Location = new System.Drawing.Point(632, 774);
            this.btnGericik.Name = "btnGericik";
            this.btnGericik.Size = new System.Drawing.Size(75, 23);
            this.btnGericik.TabIndex = 9;
            this.btnGericik.Text = "Geri çık";
            this.btnGericik.UseVisualStyleBackColor = true;
            this.btnGericik.Click += new System.EventHandler(this.btnGericik_Click);
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 834);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGericik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPakettipiEkle;
        private System.Windows.Forms.TextBox txtKategoriEkle;
        private System.Windows.Forms.TextBox txtMiktarEkle;
        private System.Windows.Forms.TextBox txtUruntanimiEkle;
        private System.Windows.Forms.TextBox txtUrunadiEkle;
        private System.Windows.Forms.TextBox txtUrunkilifiEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
    }
}