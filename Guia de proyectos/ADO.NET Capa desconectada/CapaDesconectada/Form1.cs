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
    }
}
