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

namespace Dapper
{
    public partial class Form1 : Form
    {
        CustomerRepository cr = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerTodos();
            dataGridView1.DataSource = cliente;
        }
    }
}
