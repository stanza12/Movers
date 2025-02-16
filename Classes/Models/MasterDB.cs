using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SR_Movers_coursework
{
   public class MasterDB
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Movers"].ConnectionString;
    }
}
