using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace AccesoDatos
{
    public class CustomerRepository
    {
        public DataTable Obtenertodos() {
            DataTable dataTable = new DataTable();
            String select = "";
            select = select + "SELECT [CustomerID] " + "\n";
            select = select + "      ,[CompanyName] " + "\n";
            select = select + "      ,[ContactName] " + "\n";
            select = select + "      ,[ContactTitle] " + "\n";
            select = select + "      ,[Address] " + "\n";
            select = select + "      ,[City] " + "\n";
            select = select + "      ,[Region] " + "\n";
            select = select + "      ,[PostalCode] " + "\n";
            select = select + "      ,[Country] " + "\n";
            select = select + "      ,[Phone] " + "\n";
            select = select + "      ,[Fax] " + "\n";
            select = select + "  FROM [dbo].[Customers]";

            var conexion = @"Data Source=SNEYKER;Initial Catalog=Northwind;Integrated Security=True;";
            SqlDataAdapter adapter = new SqlDataAdapter(select, conexion);
            adapter.Fill(dataTable);

            return dataTable;


        }

        public Customers ObetenerPorId(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var dataTable = new DataTable();

                String selectForId = "";
                selectForId = selectForId + "SELECT [CustomerID] " + "\n";
                selectForId = selectForId + "      ,[CompanyName] " + "\n";
                selectForId = selectForId + "      ,[ContactName] " + "\n";
                selectForId = selectForId + "      ,[ContactTitle] " + "\n";
                selectForId = selectForId + "      ,[Address] " + "\n";
                selectForId = selectForId + "      ,[City] " + "\n";
                selectForId = selectForId + "      ,[Region] " + "\n";
                selectForId = selectForId + "      ,[PostalCode] " + "\n";
                selectForId = selectForId + "      ,[Country] " + "\n";
                selectForId = selectForId + "      ,[Phone] " + "\n";
                selectForId = selectForId + "      ,[Fax] " + "\n";
                selectForId = selectForId + "  FROM [dbo].[Customers] " + "\n";
                selectForId = selectForId + "  Where CustomerID = @CustomerID";
                using (var comando = new SqlCommand(selectForId, conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", id);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dataTable);
                    Customers cliente = ExtraerInfoCliente(dataTable);
                    return cliente;
                }
            }
        }

        public Customers ExtraerInfoCliente(DataTable dataTeble)
        {
            Customers customer = new Customers();
            foreach (DataRow fila in dataTeble.Rows)
            {
                customer.CustomerID = fila.Field<string>("CustomerID");
                customer.CompanyName = fila.Field<string>("CompanyName");
                customer.ContactName = fila.Field<string>("ContactName");
                customer.ContactTitle = fila.Field<string>("ContactTitle");
                customer.Address = fila.Field<string>("Address");
                customer.City = fila.Field<string>("City");
                customer.Region = fila.Field<string>("Region");
                customer.PostalCode = fila.Field<string>("PostalCode");
                customer.Country = fila.Field<string>("Country");
                customer.Phone = fila.Field<string>("Phone");
                customer.Fax = fila.Field<string>("Fax");
            }
            return customer;
        }

        public int InsertarCliente(Customers cliente) {
            using (var conexion = DataBase.GetSqlConnection()) {

                String InsertarporId = "";
                InsertarporId = InsertarporId + "INSERT INTO [dbo].[Customers] " + "\n";
                InsertarporId = InsertarporId + "           ([CustomerID] " + "\n";
                InsertarporId = InsertarporId + "           ,[CompanyName] " + "\n";
                InsertarporId = InsertarporId + "           ,[ContactName] " + "\n";
                InsertarporId = InsertarporId + "           ,[ContactTitle] " + "\n";
                InsertarporId = InsertarporId + "           ,[Address]) " + "\n";
                InsertarporId = InsertarporId + "     VALUES " + "\n";
                InsertarporId = InsertarporId + "           (@CustomerID " + "\n";
                InsertarporId = InsertarporId + "           ,@CompanyName " + "\n";
                InsertarporId = InsertarporId + "           ,@ContactName " + "\n";
                InsertarporId = InsertarporId + "           ,@ContactTitle " + "\n";
                InsertarporId = InsertarporId + "           ,@Address)";

                using (var commando = new SqlCommand(InsertarporId, conexion)) {
                    commando.Parameters.AddWithValue("CustomerID", cliente.CustomerID);
                    commando.Parameters.AddWithValue("CompanyName", cliente.CompanyName);
                    commando.Parameters.AddWithValue("ContactName", cliente.ContactName);
                    commando.Parameters.AddWithValue("ContactTitle", cliente.ContactTitle);
                    commando.Parameters.AddWithValue("Address", cliente.Address);
                    SqlDataAdapter adaptador = new SqlDataAdapter(commando);
                    adaptador.InsertCommand = commando;
                  return  adaptador.InsertCommand.ExecuteNonQuery();
                }
            }
        }
    }

   
}
