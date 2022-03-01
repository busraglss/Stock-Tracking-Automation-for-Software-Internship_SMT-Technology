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
    public partial class frmStokKontrol : Form
    {
        public frmStokKontrol()
        {
            InitializeComponent();
        }
        clsProgPath path = new clsProgPath();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGericik_Click(object sender, EventArgs e)
        {
            #region Buton ile geri çıkma
            this.Close();
            #endregion
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            #region Stok Sorgulama işlemi
            if (string.IsNullOrWhiteSpace(txtUrunadi.Text))
            {
                MessageBox.Show("Lütfen ürün kılıfı alanını doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //string sqldb_constr = "Data Source=DESKTOP-92RJB4J\\SQLEXPRESS;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                //string sqldb_constr = "Data Source=LAPTOP-4POAQL4Q;Initial Catalog=SMTStok;Integrated Security=True"; //Veri tabanı bağlantısı.
                SqlConnection baglan = new SqlConnection(path.program_path);
                baglan.Open();
                SqlCommand komut = new SqlCommand($"SELECT * FROM urunler WHERE urunadi='{txtUrunadi.Text}'", baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglan.Close();

            }
        }
        #endregion

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }
      }
    }

