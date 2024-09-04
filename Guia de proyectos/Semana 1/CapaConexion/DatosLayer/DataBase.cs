using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace DatosLayer
{
    public class DataBase
    {

        public static int ConnetionTimeout { get; set; }
        public static string ApplicationName { get; set; }


        public static String ConnectionString
        {
            get
            {
                String CadenaConexion = ConfigurationManager
                   .ConnectionStrings["NWConnection"]
                   .ConnectionString;

                SqlConnectionStringBuilder conexionBuilder =
                    new SqlConnectionStringBuilder(CadenaConexion);

                conexionBuilder.ApplicationName =
                ApplicationName ?? conexionBuilder.ApplicationName;
                conexionBuilder.ConnectTimeout = (ConnetionTimeout > 0)
                    ? ConnetionTimeout : conexionBuilder.ConnectTimeout;
                return conexionBuilder.ToString();
            }

        }
        public static SqlConnection GetSqlConnection()
        {

            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;
        }
    }
}
