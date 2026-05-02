using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroServicio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdenServicio ordenServicio = new OrdenServicio();
            ordenServicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoServicio tipoServicio = new TipoServicio();
            tipoServicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaOrdenes consultaOrdenes = new ConsultaOrdenes();
            consultaOrdenes.Show();
        }
    }
}
