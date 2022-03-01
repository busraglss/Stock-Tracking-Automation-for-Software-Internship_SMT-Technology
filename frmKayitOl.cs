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
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }
        clsProgPath path = new clsProgPath();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGeriCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKayitOl_Load(object sender, EventArgs e)
        {
            #region Form yüklendiğinde comboboxlara veri getirme
            cmbHesapEkle.Items.Add("Admin");
            cmbHesapEkle.Items.Add("Kullanıcı");

            cmbCinsiyet.Items.Add("Kadın");
            cmbCinsiyet.Items.Add("Erkek");
            #endregion

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            #region Kayıt olma işlemi
            if (string.IsNullOrWhiteSpace(txtKullaniciEkle.Text) || string.IsNullOrWhiteSpace(txtParolaEkle.Text) || string.IsNullOrWhiteSpace(cmbHesapEkle.Text) || string.IsNullOrWhiteSpace(cmbCinsiyet.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                using (var baglan = new SqlConnection(path.program_path))
                {
                    using (var komut = new SqlCommand($"insert into kullanicilar(kullanici,parola,hesapturu,cinsiyet) values('{txtKullaniciEkle.Text}','{txtParolaEkle.Text}','{cmbHesapEkle.Text}','{cmbCinsiyet.Text}')", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kullanıcı veritabanına eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtKullaniciEkle.Text = "";
                            txtParolaEkle.Text = "";
                            cmbHesapEkle.Text = string.Empty;
                            cmbCinsiyet.Text = string.Empty;
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message);
                        }
                        GC.Collect();
                        //Çöp Toplayıcısı
                        GC.WaitForPendingFinalizers();
                        //Çöp Yakıcısı
                    }
                }
            }
            #endregion
        }

        private void btnKayitgoster_Click(object sender, EventArgs e)
        {
            #region Kayıtlı kullanıcı göster

            //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            SqlConnection baglan = new SqlConnection(path.program_path);
            baglan.Open();
            SqlCommand komut = new SqlCommand($"SELECT * FROM kullanicilar", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            #endregion
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            #region Kullanıcı silme işlemi
            //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            using (var baglan = new SqlConnection(path.program_path))
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        using (var komut = new SqlCommand($"delete from kullanicilar where kullanici='" + dataGridView1.SelectedRows[i].Cells["kullanici"].Value.ToString() + "'", baglan))
                        {
                            try
                            {
                                komut.Connection.Open();
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Kullanıcı veritabanından çıkarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show(hata.Message);
                            }
                        }
                    }
                 
            }
            #endregion
        }
    }
}
