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

namespace EFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private CustomerRepository cr = new CustomerRepository();
        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerTodos();
            dgvCustomers.DataSource = cliente;
        }

        private void txbObtenerTodos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerPorID(txbObtenerTodos.Text);
            List<Customers> lista1 = new List<Customers> { cliente
            };
            if (cliente != null)
            {
                llenarCampos(cliente);
            }
            dgvCustomers.DataSource = lista1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Customers crearCliente()
        {
            var cliente = new Customers { 
            CustomerID = txbCustomerID.Text,
            CompanyName = txbCompanyName.Text,
            ContactName = txbContactName.Text,
            ContactTitle = txbContactTitle.Text,
            Address = txbAddress.Text,
            };
            return cliente;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = crearCliente();
                var resultado = cr.InsertarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show($"Se insertó correctamente {resultado} fila(s).");
                }
                else
                {
                    MessageBox.Show("Error: No se pudo insertar el cliente.");
                }
            }
            catch (Exception ex)
            {
                // Capturamos cualquier error inesperado y mostramos el mensaje
                MessageBox.Show($"Ocurrió un error al insertar el cliente: {ex.Message}");
            }
        }

        private void llenarCampos(Customers customers)
        {
            txbCustomerID.Text = customers.CustomerID;
            txbCompanyName.Text = customers.CompanyName;
            txbContactName.Text = customers.ContactName;
            txbContactTitle.Text = customers.ContactTitle;
            txbAddress.Text = customers.Address;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cliente = crearCliente();
            cr.UpdateClientes(cliente);
            var resultado = cr.ObtenerPorID(cliente.CustomerID);
            List<Customers> lista1 = new List<Customers> { 
            };
            dgvCustomers.DataSource = lista1;
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            var eliminadas = cr.DeleteCliente(txbCustomerID.Text);
            MessageBox.Show($"Se extermino la fila {eliminadas}");
        }
    }
}
