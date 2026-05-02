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
    public partial class TipoServicio : Form
    {
        public TipoServicio()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TipoServicio_Load(object sender, EventArgs e)
        {
            txtIdTipoServicio.Enabled = false;
            rbActivo.Checked = true;

            CargarTipos();
        }
        private void CargarTipos()
        {
            string query = "SELECT IdTipoServicio, NombreTipoServicio, Estatus FROM TipoServicio ORDER BY NombreTipoServicio";

            dgvTipoServicio.DataSource = Consultas.Consultar(query, null);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string estatus = rbActivo.Checked ? "Activo" : "Inactivo";

            string query = @"
        INSERT INTO TipoServicio
        (NombreTipoServicio, Estatus)
        VALUES
        (@Nombre, @Estatus)";

            var parametros = new Dictionary<string, object>
    {
        { "@Nombre", txtNombreTipoServicio.Text },
        { "@Estatus", estatus }
    };

            Consultas.Ejecutar(query, parametros);

            MessageBox.Show("Tipo de servicio guardado");
            //Limpiar();
            CargarTipos();
        }
    }

}
