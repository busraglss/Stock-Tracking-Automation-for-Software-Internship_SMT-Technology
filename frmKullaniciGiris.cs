using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace StockTrackingAutomation
{
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }
        clsProgPath path = new clsProgPath();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            #region Kayıt olma form ekranına geçiş
            if (string.IsNullOrWhiteSpace(txtAktifGiris.Text)) // Sistemde anlık kullanıcı mevcut ise kayıt olma işlemine geçiş yapmasını engelleyen döngü
            {
                frmKayitOl ekle = new frmKayitOl();
                ekle.ShowDialog();

            }
            else
            {
                MessageBox.Show("Lütfen önce çıkış yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            #region Kullanıcı çıkış işlemi
            if (string.IsNullOrWhiteSpace(txtAktifGiris.Text)) //Kullanıcı girişi yapılmadan çıkış yapılmasını engelleyen döngü
            {
                MessageBox.Show("Lütfen önce giriş yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtAktifGiris.Text = " ";
                txtKullanici.Clear();
                txtParola.Clear();
                MessageBox.Show("Çıkış yaptınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            #endregion
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            #region Kullanıcı girişi
            if (string.IsNullOrWhiteSpace(txtKullanici.Text) || string.IsNullOrWhiteSpace(txtParola.Text)) // Bütün alanların dolu olup olmadığını kontrol eden döngü
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

               // string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
               // string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                SqlConnection baglan = new SqlConnection(path.program_path);
                baglan.Open();
                SqlCommand komut = new SqlCommand($"SELECT * FROM kullanicilar WHERE kullanici='{txtKullanici.Text}'AND parola='{txtParola.Text}'", baglan);
                komut.Parameters.AddWithValue("@kullanici", txtKullanici.Text);
                komut.Parameters.AddWithValue("@parola", txtParola.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Giriş yapıldı.", "Başarılı");
                    txtAktifGiris.Text = $"{txtKullanici.Text}";
                    frmAnasayfa.kullanici = $"{txtKullanici.Text}";
                    txtKullanici.Clear();
                    txtParola.Clear();
                    frmAnasayfa ekle = new frmAnasayfa();
                    ekle.ShowDialog();
                  
                }
                else
                {
                    MessageBox.Show("Giriş yapılamadı.", "Başarısız");
                }

            }
            #endregion
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void frmKullaniciGiris_KeyDown(object sender, KeyEventArgs e)
        {
            #region Enter tuşu ile giriş yapma butonu kontrolü
            if (e.KeyCode==Keys.Enter)
            {
                btnGirisYap.PerformClick();
            }
            #endregion
        }

        private void frmKullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
