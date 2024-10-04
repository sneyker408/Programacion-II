using AccesoDatos;
using CapaDesconectada.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesconectada
{
    public partial class Form1 : Form
    {
        #region No Tipado 
        private CustomerRepository customerRepository = new CustomerRepository();
        private void btnObtenerNotipado_Click(object sender, EventArgs e)
        {

            gridNotipado.DataSource = customerRepository.Obtenertodos();
        }
        private void btBuscarPorIdNt_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObetenerPorId(tboxObtenerNt.Text);
            if (cliente == null) {
                MessageBox.Show("El objeto es null");
            }
            if (cliente != null) {
                var listaClientes = new List<Customers> { cliente };
                gridNotipado.DataSource = listaClientes;
            }
        }

        private void btonInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registrados");
        }
        private Customers CrearCliente() { 
          var cliente = new Customers { 
          CustomerID = tboxCustomerID.Text,
          CompanyName = tboxCompaniName.Text,
          ContactName = tboxContactName.Text,
          ContactTitle = tboxContactTitle.Text,
          Address = tboxAddres.Text,
          };
            MessageBox.Show(cliente.CustomerID);
            MessageBox.Show(cliente.CompanyName);
            MessageBox.Show(cliente.ContactName);
            MessageBox.Show(cliente.ContactTitle);
            MessageBox.Show(cliente.Address);
            return cliente;
        }
        #endregion

        #region tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;
        }
        private void btnBuscarTipado_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(tboxBuscarTipado.Text);
            
            if (customer != null) {
              var objeto1 =customerRepository.ExtraerInfoCliente(customer);
                Console.WriteLine(customer);
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      
    }
}
