using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class ConnectionString
    {
        public static string ConStrLive = @"Data Source=.;Initial Catalog=OziMar;Integreted Security=True";
        public static string ConStrTest = @"Data Source=DESKTOP-67EH4HA;InitialCatalog=OziMar;Integreted Security=True";
    }
}
