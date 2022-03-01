using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace StockTrackingAutomation
{
    class clsProgPath
    {

        public string program_path = File.ReadAllText(@"C:\Stok\Stockpath.txt");
    }
}
