using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        CustomerRepository customerR = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerTodos();
            dgvCustomers.DataSource = cliente;  
        }

        private void btnObtenerId_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerPorID(tboxOBtenerID.Text);
             dgvCustomers.DataSource = new List<Customers> { cliente };
        }

        private Customers CrearCliente() {
            var nuevo = new Customers {
                CustomerID = txbCustomerId.Text,
                CompanyName = txbCompanyName.Text,
                ContactName = txbContactName.Text,
                ContactTitle= tbxContactTitle.Text,
                Address= txbAddress.Text
            };
            return nuevo;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = CrearCliente();
            var insertado = customerR.insertarCliente(nuevoCliente);
            MessageBox.Show($"{insertado} registros insertados");
        }
    }
}
