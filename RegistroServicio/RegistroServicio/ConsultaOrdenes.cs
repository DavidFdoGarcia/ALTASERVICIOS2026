using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using RegistroServicio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace RegistroServicio
{
    public partial class ConsultaOrdenes : Form
    {
        public ConsultaOrdenes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaOrdenes_Load(object sender, EventArgs e)
        {
            CargarTipoServicio();
            CargarEstatus();

            dtpInicio.Value = DateTime.Today.AddMonths(-1);
            dtpFin.Value = DateTime.Today;

            ConfigurarGrid();
            ConsultarOrdenes();
        }
        private void CargarTipoServicio()
        {
            string query = @"
SELECT IdTipoServicio, NombreTipoServicio
FROM TipoServicio
ORDER BY NombreTipoServicio";

            DataTable dt = Consultas.Consultar(query, null);

            DataRow fila = dt.NewRow();
            fila["IdTipoServicio"] = 0;
            fila["NombreTipoServicio"] = "Todos";
            dt.Rows.InsertAt(fila, 0);

            cmbTipoServicio.DataSource = dt;
            cmbTipoServicio.DisplayMember = "NombreTipoServicio";
            cmbTipoServicio.ValueMember = "IdTipoServicio";
        }



        private void CargarEstatus()
        {
            cmbEstatus.Items.Clear();
            cmbEstatus.Items.Add("Todos");
            cmbEstatus.Items.Add("Pendiente");
            cmbEstatus.Items.Add("En proceso");
            cmbEstatus.Items.Add("Terminado");
            cmbEstatus.Items.Add("Cancelado");
            cmbEstatus.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenes.MultiSelect = false;
            dgvOrdenes.ReadOnly = true;
            dgvOrdenes.AllowUserToAddRows = false;
        }

        private void ConsultarOrdenes()
        {
            string query = @"
SELECT 
    os.IdOrden,
    os.FechaServicio,
    c.NombreCliente,
    ts.NombreTipoServicio,
    os.ObjetoServicio,
    os.Marca,
    os.Modelo,
    os.Tecnico,
    os.Estatus,
    CASE WHEN os.Facturado = 1 THEN 'Sí' ELSE 'No' END AS Facturado
FROM OrdenServicio os
INNER JOIN Cliente c ON os.IdCliente = c.IdCliente
INNER JOIN TipoServicio ts ON os.IdTipoServicio = ts.IdTipoServicio
WHERE
    (
        c.NombreCliente LIKE @Buscar OR
        c.Empresa LIKE @Buscar OR
        ts.NombreTipoServicio LIKE @Buscar OR
        os.ObjetoServicio LIKE @Buscar OR
        os.Marca LIKE @Buscar OR
        os.Modelo LIKE @Buscar OR
        os.Serie LIKE @Buscar OR
        os.Tecnico LIKE @Buscar OR
        CAST(os.IdOrden AS VARCHAR) LIKE @Buscar
    )
    AND os.FechaServicio >= @FechaInicio
    AND os.FechaServicio < @FechaFin
    AND (@IdTipoServicio = 0 OR os.IdTipoServicio = @IdTipoServicio)
    AND (@Estatus = 'Todos' OR os.Estatus = @Estatus)
    AND (@SoloNoFacturados = 0 OR os.Facturado = 0)
ORDER BY os.IdOrden DESC";

            var parametros = new Dictionary<string, object>
            {
                { "@Buscar", "%" + txtBuscar.Text.Trim() + "%" },
                { "@FechaInicio", dtpInicio.Value.Date },
                { "@FechaFin", dtpFin.Value.Date.AddDays(1) },
                { "@IdTipoServicio", Convert.ToInt32(cmbTipoServicio.SelectedValue) },
                { "@Estatus", cmbEstatus.Text },
                { "@SoloNoFacturados", chkSoloNoFacturados.Checked ? 1 : 0 }
            };

            dgvOrdenes.DataSource = Consultas.Consultar(query, parametros);

            FormatearGrid();
        }

        private void FormatearGrid()
        {
            if (dgvOrdenes.Columns.Contains("IdOrden"))
                dgvOrdenes.Columns["IdOrden"].HeaderText = "Folio";

            if (dgvOrdenes.Columns.Contains("FechaServicio"))
                dgvOrdenes.Columns["FechaServicio"].HeaderText = "Fecha";

            if (dgvOrdenes.Columns.Contains("NombreCliente"))
                dgvOrdenes.Columns["NombreCliente"].HeaderText = "Cliente";

            if (dgvOrdenes.Columns.Contains("NombreTipoServicio"))
                dgvOrdenes.Columns["NombreTipoServicio"].HeaderText = "Tipo de Servicio";

            if (dgvOrdenes.Columns.Contains("ObjetoServicio"))
                dgvOrdenes.Columns["ObjetoServicio"].HeaderText = "Equipo";

            if (dgvOrdenes.Columns.Contains("Facturado"))
                dgvOrdenes.Columns["Facturado"].HeaderText = "Facturado";
        }

        private int ObtenerIdOrdenSeleccionada()
        {
            if (dgvOrdenes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una orden.");
                return 0;
            }

            return Convert.ToInt32(dgvOrdenes.CurrentRow.Cells["IdOrden"].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarOrdenes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            if (cmbTipoServicio.Items.Count > 0)
                cmbTipoServicio.SelectedValue = 0;

            cmbEstatus.SelectedIndex = 0;
            chkSoloNoFacturados.Checked = false;

            dtpInicio.Value = DateTime.Today.AddMonths(-1);
            dtpFin.Value = DateTime.Today;

            ConsultarOrdenes();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int idOrden = ObtenerIdOrdenSeleccionada();

            if (idOrden == 0)
                return;

            MessageBox.Show("Orden seleccionada: " + idOrden);
        }

        private void dgvOrdenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idOrden = Convert.ToInt32(dgvOrdenes.Rows[e.RowIndex].Cells["IdOrden"].Value);

            MessageBox.Show("Orden seleccionada: " + idOrden);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOrdenes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idOrden = Convert.ToInt32(dgvOrdenes.Rows[e.RowIndex].Cells["IdOrden"].Value);

            EditarOrden frm = new EditarOrden(idOrden);
            frm.ShowDialog();

            ConsultarOrdenes();
        }
    }
}