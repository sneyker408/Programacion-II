using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public  class AccesoDatos
    {

        public static string ConnectionString
        {
            get { 
                    return ConfigurationManager. ConnectionStrings["NWConnectionString"].ConnectionString;
            
            }
        }


        public static SqlConnection getConnction() { 
            SqlConnection connection = new SqlConnection (ConnectionString);
            connection.Open ();
            return connection;
        }
    }
}
