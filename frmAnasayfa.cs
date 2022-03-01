using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StockTrackingAutomation
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        static public string kullanici;
        public frmKullaniciGiris frmKG;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStokKontrol_Click(object sender, EventArgs e)
        {
            #region Stok Kontrol form ekranına geçiş
                frmStokKontrol ekle = new frmStokKontrol ();
                ekle.ShowDialog();
            #endregion
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            #region Ürün ekleme form ekranına geçiş
            
                frmUrunEkle ekle = new frmUrunEkle();
                ekle.ShowDialog();
            #endregion
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            #region Ürün güncelleme form ekranına geçiş
          
                frmUrunGuncelle ekle = new frmUrunGuncelle();
                ekle.ShowDialog();
            #endregion
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            #region Kullanıcı giriş ekranına geri dön buton işlemleri
            
            frmKullaniciGiris frmKG =(frmKullaniciGiris)Application.OpenForms["frmKullaniciGiris"];
            Application.OpenForms["frmKullaniciGiris"].Show();
            this.Hide();
            
            #endregion
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            txtAktifGirisAnasyf.Text = kullanici;
        }

        private void frmAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
