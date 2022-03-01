using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StockTrackingAutomation
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StreamWriter sw = new StreamWriter(@"C:\Stok\Stockpath.txt", true);
            sw.Close();
            string klasoradi = @"c:\Stok";
            System.IO.Directory.CreateDirectory(klasoradi);
            //string dosyaadi = "Stok_program_path.txt";
            //string dosyayolu = @"c:\Stok";
            //System.IO.File.Create
            //string hedef_yol = Path.Combine(dosyaadi, dosyayolu);



            //if (System.IO.File.Exists(hedef_yol))
            //{
            //    MessageBox.Show("Dosya mevcuttur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else
            //{
            //    System.IO.File.Create(hedef_yol);
            //    MessageBox.Show("Dosya oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


            // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplashScreen());
        }
    }
}
