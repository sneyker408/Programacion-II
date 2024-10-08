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
        //Fomr 1 
        CustomerRepository customerR = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // objelo load aparece al precionar el bode azul del formulario 
        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerTodos();
            dgvCustomers.DataSource = cliente;
        }

        private void btnObtenerId_Click(object sender, EventArgs e)
        {
            // Obtenemos el cliente por ID
            var cliente = customerR.ObtenerPorID(tBoxOBtenerID.Text);

            if (cliente != null)
            {
                // Asignamos el cliente a una lista para mostrar en el DataGridView
                dgvCustomers.DataSource = new List<Customers> { cliente };
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }
        private Customers CrearCliente()
        {
            var nuevo = new Customers
            {
                CustomerID = txbCustomerId.Text,
                CompanyName = txbCompanyName.Text,
                ContactName = txbContactName.Text,
                ContactTitle = txbContactTitle.Text,
                Address = txbAddress.Text
            };
            return nuevo;
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = CrearCliente();
            var insertado = customerR.insertarCliente(nuevoCliente);
            MessageBox.Show($"{insertado} registros insertados");
        }
    }
}
