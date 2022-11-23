using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class ConnectionString
    {
        public static string ConStrLive = @"Data Source=.;Initial Catalog=OziMar;Integrated Security=True";
        public static string ConStrTest = @"Data Source=DESKTOP-67EH4HA;Initial Catalog=OziMarDB;Integrated Security=True";
    }
}
