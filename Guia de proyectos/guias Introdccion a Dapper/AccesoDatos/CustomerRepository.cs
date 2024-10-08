using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public  class CustomerRepository
    {
        public List<Customers> ObtenerTodos() {
            using (var conexion = DataBase.GetSqlConnection()) {

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
        public Customers ObtenerPorID(string id) {

            using (var conexion = DataBase.GetSqlConnection()) {

                String selectPorID = "";
                selectPorID = selectPorID + "SELECT [CustomerID] " + "\n";
                selectPorID = selectPorID + "      ,[CompanyName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactTitle] " + "\n";
                selectPorID = selectPorID + "      ,[Address] " + "\n";
                selectPorID = selectPorID + "      ,[City] " + "\n";
                selectPorID = selectPorID + "      ,[Region] " + "\n";
                selectPorID = selectPorID + "      ,[PostalCode] " + "\n";
                selectPorID = selectPorID + "      ,[Country] " + "\n";
                selectPorID = selectPorID + "      ,[Phone] " + "\n";
                selectPorID = selectPorID + "      ,[Fax] " + "\n";
                selectPorID = selectPorID + "  FROM [dbo].[Customers] " + "\n";
                selectPorID = selectPorID + "  WHERE CustomerID = @CustomerID";

                var Cliente = conexion.QueryFirstOrDefault<Customers>(selectPorID, new { CustomerID = id });
                return Cliente;
            }
              
        }
        public int insertarCliente(Customers customer) {
            using (var conexion = DataBase.GetSqlConnection()) {
                String Insertar = "";
                Insertar = Insertar + "INSERT INTO [dbo].[Customers] " + "\n";
                Insertar = Insertar + "           ([CustomerID] " + "\n";
                Insertar = Insertar + "           ,[CompanyName] " + "\n";
                Insertar = Insertar + "           ,[ContactName] " + "\n";
                Insertar = Insertar + "           ,[ContactTitle] " + "\n";
                Insertar = Insertar + "           ,[Address]) " + "\n";
                Insertar = Insertar + "     VALUES " + "\n";
                Insertar = Insertar + "           (@customerID " + "\n";
                Insertar = Insertar + "           ,@companyName " + "\n";
                Insertar = Insertar + "           ,@contactName " + "\n";
                Insertar = Insertar + "           ,@contactTitle " + "\n";
                Insertar = Insertar + "           ,@address)";
                var insertadas = conexion.Execute(Insertar, new
                {
                    CustomerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    ContactTitle = customer.ContactTitle,
                    Address = customer.Address,
                });
                return insertadas;
            }
        }
        public int AcctualizarCliente(Customers customers) {
            using (var conexion = DataBase.GetSqlConnection()) {
                String UpdateCustomer = "";
                UpdateCustomer = UpdateCustomer + "UPDATE [dbo].[Customers] " + "\n";
                UpdateCustomer = UpdateCustomer + "   SET [CustomerID] = @CustomerID " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[CompanyName] = @CompanyName " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[ContactName] = @ContactName " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[ContactTitle] = @ContactTitle " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[Address] = @Address " + "\n";
                UpdateCustomer = UpdateCustomer + " WHERE CustomerID = @CustomerID";


                var actualizadas =
                    conexion.Execute(UpdateCustomer, new {
                    CustomerID = customers.CustomerID,
                        CompanyName = customers.CompanyName,
                        ContactName = customers.ContactName,
                        ContactTitle = customers.ContactTitle,
                        Address = customers.Address
                    });
                return actualizadas;
            }
        }


        public int EliminarCliente(string Id) {

            using (var conexion = DataBase.GetSqlConnection()) {

                String Delete = "";
                Delete = Delete + "DELETE FROM [dbo].[Customers] " + "\n";
                Delete = Delete + "      WHERE CustomerID = @CustomerID";

                var eliminadas = conexion.Execute(Delete, new
                {
                    CustomerID = Id
                });
                return eliminadas;
            }
        }
    }
}
