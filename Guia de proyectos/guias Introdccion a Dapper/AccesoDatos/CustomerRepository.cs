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
        public List<Customers> ObtenerTodos()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {

                String sqlSelectAll = "";
                sqlSelectAll = sqlSelectAll + "SELECT [CustomerID] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[CompanyName] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[ContactName] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[ContactTitle] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Address] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[City] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Region] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[PostalCode] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Country] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Phone] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Fax] " + "\n";
                sqlSelectAll = sqlSelectAll + "  FROM [dbo].[Customers]";

                var cliente = conexion.Query<Customers>(sqlSelectAll).ToList();
                return cliente;
            }
        }
    }
}
