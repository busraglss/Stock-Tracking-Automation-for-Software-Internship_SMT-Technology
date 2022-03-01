using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StockTrackingAutomation
{
    public partial class frmUrunGuncelle : Form
    {
        public frmUrunGuncelle()
        {
            InitializeComponent();
        }
        clsProgPath path = new clsProgPath();
        private void btnGericik_Click(object sender, EventArgs e)
        {
            #region Buton ile geri çıkma
            this.Close();
            #endregion
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            #region Ürün güncelleme işlemi

            if (string.IsNullOrWhiteSpace(txtUrunkilifiGuncelle.Text) || string.IsNullOrWhiteSpace(txtUrunadiGuncelle.Text) || string.IsNullOrWhiteSpace(txtUruntanimiGuncelle.Text) || string.IsNullOrWhiteSpace(txtKategoriGuncelle.Text) || string.IsNullOrWhiteSpace(txtPakettipiGuncelle.Text) || string.IsNullOrWhiteSpace(txtMiktarGuncelle.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

               //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.               
              //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                DialogResult stgu = MessageBox.Show("Stoklar güncellensin mi?", "Stok durumu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (stgu == DialogResult.Yes)
                {
                    using (var baglan = new SqlConnection(path.program_path))
                    {
                        using (var komut = new SqlCommand("UPDATE urunler SET urunmiktari='" + txtMiktarGuncelle.Text + "' WHERE  urunkilifi='" + txtUrunkilifiGuncelle.Text + "'", baglan))
                        {
                            try
                            {
                                komut.Connection.Open();
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Ürün stoğu güncellenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUrunkilifiGuncelle.Text = "";
                                txtUrunadiGuncelle.Text = "";
                                txtUruntanimiGuncelle.Text = "";
                                txtKategoriGuncelle.Text = "";
                                txtPakettipiGuncelle.Text = "";
                                txtMiktarGuncelle.Text = "";

                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show("Güncelleme başarısız." + hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                #endregion
            }
        }
            private void btnVerigor_Click(object sender, EventArgs e)
        {
            #region Ürün bilgilerini göster
            if (string.IsNullOrWhiteSpace(txtUrunadiGuncelle.Text) || string.IsNullOrWhiteSpace(txtPakettipiGuncelle.Text) || string.IsNullOrWhiteSpace(txtUrunkilifiGuncelle.Text))
            {
                MessageBox.Show("Lütfen ürün adı ve paket tipi alanlarını doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                using (var baglan = new SqlConnection(path.program_path))
                {
                    using (var komut = new SqlCommand($"SELECT * FROM urunler WHERE urunkilifi='{txtUrunkilifiGuncelle.Text}' AND urunadi='{txtUrunadiGuncelle.Text}' AND pakettipi='{txtPakettipiGuncelle.Text}'", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            SqlDataReader dtr = komut.ExecuteReader();
                            if (dtr.Read())
                            {
                                txtUruntanimiGuncelle.Text = dtr["uruntanimi"].ToString();
                                txtKategoriGuncelle.Text = dtr["kategori"].ToString();
                                txtMiktarGuncelle.Text = dtr["urunmiktari"].ToString();
                            }
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Ürün bilgileri bulunamadı." + hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            #endregion
        }
    }
}
