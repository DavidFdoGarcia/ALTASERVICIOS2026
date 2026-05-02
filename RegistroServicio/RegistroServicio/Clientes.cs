using RegistroServicio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroServicio
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = false;
            rbActivo.Checked = true;

            CargarClientes();
        }
        private void CargarClientes()
        {
            string query = "SELECT IdCliente, NombreCliente, Telefono, Empresa, Estatus FROM Cliente ORDER BY NombreCliente";

            dgvClientes.DataSource = Consultas.Consultar(query, null);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtIdCliente.Text = "";
            txtNombreCliente.Text = "";
            txtTelefono.Text = "";
            txtEmpresa.Text = "";
            txtCorreo.Text = "";
            txtDomicilio.Text = "";
            rbActivo.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string estatus = rbActivo.Checked ? "Activo" : "Inactivo";

            string query = @"
        INSERT INTO Cliente
        (NombreCliente, Telefono, Empresa, Correo, Domicilio, Estatus)
        VALUES
        (@Nombre, @Telefono, @Empresa, @Correo, @Domicilio, @Estatus)";

            var parametros = new Dictionary<string, object>
    {
        { "@Nombre", txtNombreCliente.Text },
        { "@Telefono", txtTelefono.Text },
        { "@Empresa", txtEmpresa.Text },
        { "@Correo", txtCorreo.Text },
        { "@Domicilio", txtDomicilio.Text },
        { "@Estatus", estatus }
    };

            Consultas.Ejecutar(query, parametros);

            MessageBox.Show("Cliente guardado");
            Limpiar();
            CargarClientes();
        }
    }

}
