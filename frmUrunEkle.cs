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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
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

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            #region Ürün ekleme işlemi

            if (string.IsNullOrWhiteSpace(txtUrunkilifiEkle.Text) || string.IsNullOrWhiteSpace(txtUrunadiEkle.Text) || string.IsNullOrWhiteSpace(txtUruntanimiEkle.Text) || string.IsNullOrWhiteSpace(txtKategoriEkle.Text) || string.IsNullOrWhiteSpace(txtPakettipiEkle.Text) || string.IsNullOrWhiteSpace(txtMiktarEkle.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                using (var baglan = new SqlConnection(path.program_path))
                {
                    using (var komut = new SqlCommand($"insert into urunler(urunkilifi,urunadi,uruntanimi,kategori,pakettipi,urunmiktari) values('{txtUrunkilifiEkle.Text}','{txtUrunadiEkle.Text}','{txtUruntanimiEkle.Text}','{txtKategoriEkle.Text}','{txtPakettipiEkle.Text}','{txtMiktarEkle.Text}')", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Ürün veritabanın eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUrunkilifiEkle.Text = "";
                            txtUrunadiEkle.Text = "";
                            txtUruntanimiEkle.Text = "";
                            txtKategoriEkle.Text = "";
                            txtPakettipiEkle.Text = "";
                            txtMiktarEkle.Text = "";


                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Ürün kaydı tamamlanamadı." + hata, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    GC.Collect();
                    //Çöp Toplayıcısı
                    GC.WaitForPendingFinalizers();
                    //Çöp Yakıcısı

                }
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Veritabanındaki ürünleri göster

            //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            SqlConnection baglan = new SqlConnection(path.program_path);
            baglan.Open();
            SqlCommand komut = new SqlCommand($"SELECT * FROM urunler", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            #endregion
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region Seçili satır ürün silme işlemi
            //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            using (var baglan = new SqlConnection(path.program_path))
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    using (var komut = new SqlCommand($"delete from urunler where urunadi='" + dataGridView1.SelectedRows[i].Cells["urunadi"].Value.ToString() + "' and urunkilifi='" + dataGridView1.SelectedRows[i].Cells["urunkilifi"].Value.ToString() + "' and pakettipi='" + dataGridView1.SelectedRows[i].Cells["pakettipi"].Value.ToString() + "'", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Ürün veritabanından çıkarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            #region Form açıldığında datagridviewde ürünlerin gösterilmesi işlemi
            //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
            SqlConnection baglan = new SqlConnection(path.program_path);
            baglan.Open();
            SqlCommand komut = new SqlCommand($"SELECT * FROM urunler", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
#endregion
        }
    }
}
