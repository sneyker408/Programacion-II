using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;

namespace DatosLayer
{
    public class DataBase
    {

        public static String ConnectionString
        {
            get
            {
                return ConfigurationManager
                .ConnectionStrings["NWConnection"]
                .ConnectionString;

            }
        }
    }
}