using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public List<Customers> ObtenerTodos() {
            using (var conexion = AccesoDatos.getConnction()) {

                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [CustomerID] " + "\n";
                SelectAll = SelectAll + "      ,[CompanyName] " + "\n";
                SelectAll = SelectAll + "      ,[ContactName] " + "\n";
                SelectAll = SelectAll + "      ,[ContactTitle] " + "\n";
                SelectAll = SelectAll + "      ,[Address] " + "\n";
                SelectAll = SelectAll + "      ,[City] " + "\n";
                SelectAll = SelectAll + "      ,[Region] " + "\n";
                SelectAll = SelectAll + "      ,[PostalCode] " + "\n";
                SelectAll = SelectAll + "      ,[Country] " + "\n";
                SelectAll = SelectAll + "      ,[Phone] " + "\n";
                SelectAll = SelectAll + "      ,[Fax] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Customers]";

                var clientes = conexion.Query<Customers>(SelectAll).ToList();

                return clientes;
            }
        }
    }
}
