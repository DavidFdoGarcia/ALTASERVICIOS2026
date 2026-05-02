using RegistroServicio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace RegistroServicio
{
    public partial class OrdenServicio : Form
    {
        public OrdenServicio()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            string query = @"
    INSERT INTO OrdenServicio
    (
        FechaServicio,
        IdCliente,
        IdTipoServicio,
        ObjetoServicio,
        Marca,
        Modelo,
        Serie,
        FallaReportada,
        TrabajoSolicitado,
        Tecnico,
        Observaciones,
        Estatus,
        Facturado
    )
    VALUES
    (
        @Fecha,
        @Cliente,
        @Tipo,
        @Objeto,
        @Marca,
        @Modelo,
        @Serie,
        @Falla,
        @Trabajo,
        @Tecnico,
        @Obs,
        @Estatus,
        @Facturado
    );

    SELECT SCOPE_IDENTITY();
    ";

            var parametros = new Dictionary<string, object>
    {
        { "@Fecha", dtpFechaServicio.Value },
        { "@Cliente", cbCliente.SelectedValue },
        { "@Tipo", cbTipoServicio.SelectedValue },
        { "@Objeto", txtObjetoServicio.Text },
        { "@Marca", txtMarca.Text },
        { "@Modelo", txtModelo.Text },
        { "@Serie", txtSerie.Text },
        { "@Falla", txtFallaReportada.Text },
        { "@Trabajo", txtTrabajoSolicitado.Text },
        { "@Tecnico", txtTecnico.Text },
        { "@Obs", txtObservaciones.Text },
        { "@Estatus", cbEstatus.Text },
        { "@Facturado", chkFacturado.Checked }
    };

            object resultado = Consultas.EjecutarEscalar(query, parametros);

            if (resultado != null)
            {
                txtIdOrden.Text = resultado.ToString();
                MessageBox.Show("Orden guardada correctamente");
            }
        }

        private void OrdenServicio_Load(object sender, EventArgs e)
        {
            txtIdOrden.Enabled = false;

            cbEstatus.Items.Add("Registrado");
            cbEstatus.Items.Add("En proceso");
            cbEstatus.Items.Add("Terminado");
            cbEstatus.Items.Add("Entregado");
            cbEstatus.SelectedIndex = 0;

            dtpFechaServicio.Value = DateTime.Now;

            CargarClientes();
            CargarTiposServicio();
        }
        private void CargarClientes()
        {
            string query = "SELECT IdCliente, NombreCliente FROM Cliente WHERE Estatus = 'Activo' ORDER BY NombreCliente";

            DataTable dt = Consultas.Consultar(query, null);

            cbCliente.DataSource = dt;
            cbCliente.DisplayMember = "NombreCliente";
            cbCliente.ValueMember = "IdCliente";
        }
        private void CargarTiposServicio()
        {
            string query = "SELECT IdTipoServicio, NombreTipoServicio FROM TipoServicio WHERE Estatus = 'Activo'";

            DataTable dt = Consultas.Consultar(query, null);

            cbTipoServicio.DataSource = dt;
            cbTipoServicio.DisplayMember = "NombreTipoServicio";
            cbTipoServicio.ValueMember = "IdTipoServicio";
        }
        private bool Validar()
        {
            if (cbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona cliente");
                return false;
            }

            if (cbTipoServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona tipo de servicio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtObjetoServicio.Text))
            {
                MessageBox.Show("Ingresa el objeto del servicio");
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdOrden.Text = "";
            txtObjetoServicio.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtSerie.Text = "";
            txtFallaReportada.Text = "";
            txtTrabajoSolicitado.Text = "";
            txtTecnico.Text = "";
            txtObservaciones.Text = "";
            chkFacturado.Checked = false;

            cbEstatus.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdOrden.Text))
            {
                MessageBox.Show("Primero guarda la orden para poder imprimirla.");
                return;
            }

            int idOrden = Convert.ToInt32(txtIdOrden.Text);
            GenerarPDFOrden(idOrden);

        }
        private DataTable ObtenerOrdenPorId(int idOrden)
        {
            string query = @"
SELECT 
    os.IdOrden,
    os.FechaRegistro,
    os.FechaServicio,
    c.NombreCliente,
    c.Telefono,
    c.Empresa,
    c.Correo,
    c.Domicilio,
    ts.NombreTipoServicio,
    os.ObjetoServicio,
    os.Marca,
    os.Modelo,
    os.Serie,
    os.FallaReportada,
    os.TrabajoSolicitado,
    os.Tecnico,
    os.Observaciones,
    os.Estatus,
    os.Facturado
FROM OrdenServicio os
INNER JOIN Cliente c ON os.IdCliente = c.IdCliente
INNER JOIN TipoServicio ts ON os.IdTipoServicio = ts.IdTipoServicio
WHERE os.IdOrden = @IdOrden";

            var parametros = new Dictionary<string, object>
    {
        { "@IdOrden", idOrden }
    };

            return Consultas.Consultar(query, parametros);
        }

        private void GenerarPDFOrden(int idOrden)
        {
            try
            {
                QuestPDF.Settings.License = LicenseType.Community;

                DataTable dt = ObtenerOrdenPorId(idOrden);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la orden.");
                    return;
                }

                DataRow row = dt.Rows[0];

                string carpeta = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "OrdenesServicio"
                );

                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                string rutaPdf = Path.Combine(carpeta, $"OrdenServicio_{idOrden}.pdf");

                string rutaLogo = Path.Combine(Application.StartupPath, "logo con brillo negro.png");

                string facturado = Convert.ToBoolean(row["Facturado"]) ? "Sí" : "No";

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(30);

                        page.Header().Column(header =>
                        {
                            header.Item().Row(rowHeader =>
                            {
                                rowHeader.ConstantItem(110)
                                    .Height(65)
                                    .Image(rutaLogo)
                                    .FitArea();

                                rowHeader.RelativeItem().AlignCenter().Column(col =>
                                {
                                    col.Item().Text("PC SOLUCIÓN")
                                        .FontSize(20)
                                        .Bold();

                                    col.Item().Text("ORDEN DE SERVICIO")
                                        .FontSize(15)
                                        .SemiBold();
                                });

                                rowHeader.ConstantItem(110);
                            });

                            header.Item().PaddingTop(10).LineHorizontal(1);
                        });

                        page.Content().PaddingVertical(15).Column(col =>
                        {
                            col.Spacing(10);

                            col.Item().Row(rowPdf =>
                            {
                                rowPdf.RelativeItem().Text($"Folio: OS-{Convert.ToInt32(row["IdOrden"]):00000}")
                                    .Bold();

                                rowPdf.RelativeItem().AlignRight()
                                    .Text($"Fecha: {Convert.ToDateTime(row["FechaServicio"]):dd/MM/yyyy}");
                            });

                            col.Item().Text("DATOS DEL CLIENTE").Bold().FontSize(12);

                            col.Item().Border(1).Padding(8).Column(c =>
                            {
                                c.Item().Text($"Cliente: {row["NombreCliente"]}");
                                c.Item().Text($"Empresa: {row["Empresa"]}");
                                c.Item().Text($"Teléfono: {row["Telefono"]}");
                                c.Item().Text($"Correo: {row["Correo"]}");
                                c.Item().Text($"Domicilio: {row["Domicilio"]}");
                            });

                            col.Item().Text("DATOS DEL SERVICIO").Bold().FontSize(12);

                            col.Item().Border(1).Padding(8).Column(c =>
                            {
                                c.Item().Text($"Tipo de servicio: {row["NombreTipoServicio"]}");
                                c.Item().Text($"Equipo: {row["ObjetoServicio"]}");
                                c.Item().Text($"Marca: {row["Marca"]}");
                                c.Item().Text($"Modelo: {row["Modelo"]}");
                                c.Item().Text($"Serie: {row["Serie"]}");
                            });

                            col.Item().Text("DETALLE").Bold().FontSize(12);

                            col.Item().Border(1).Padding(8).Column(c =>
                            {
                                c.Item().Text("Falla reportada:").Bold();
                                c.Item().Text(row["FallaReportada"]?.ToString() ?? "");

                                c.Item().PaddingTop(5).Text("Trabajo solicitado:").Bold();
                                c.Item().Text(row["TrabajoSolicitado"]?.ToString() ?? "");

                                c.Item().PaddingTop(5).Text("Observaciones:").Bold();
                                c.Item().Text(row["Observaciones"]?.ToString() ?? "");
                            });

                            col.Item().Text("CONTROL INTERNO").Bold().FontSize(12);

                            col.Item().Border(1).Padding(8).Column(c =>
                            {
                                c.Item().Text($"Técnico: {row["Tecnico"]}");
                                c.Item().Text($"Estatus: {row["Estatus"]}");
                                c.Item().Text($"Facturado: {facturado}");
                            });

                            col.Item().PaddingTop(35).Row(r =>
                            {
                                r.RelativeItem().AlignCenter().Column(c =>
                                {
                                    c.Item().Text("____________________________");
                                    c.Item().AlignCenter().Text("Firma del cliente");
                                });

                                r.RelativeItem().AlignCenter().Column(c =>
                                {
                                    c.Item().Text("____________________________");
                                    c.Item().AlignCenter().Text("Firma del técnico");
                                });
                            });
                        });

                        page.Footer().AlignCenter().Text(text =>
                        {
                            text.Span("Documento generado por el sistema - Página ");
                            text.CurrentPageNumber();
                        });
                    });
                }).GeneratePdf(rutaPdf);

                Process.Start(new ProcessStartInfo(rutaPdf)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF:\n" + ex.Message);
            }
        }
    }
}