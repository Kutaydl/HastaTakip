using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip
{
    class Databaseconnection
    {
        public string ConSource()
        {
            string conString = "Data Source=DELL;Initial Catalog=HastaTakip;Integrated Security=True";
            return conString;
        }
    }
}
