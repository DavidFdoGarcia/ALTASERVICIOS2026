using RegistroServicio.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace RegistroServicio
{
    public partial class EditarOrden : Form
    {
        private int idOrden;

        public EditarOrden(int idOrden)
        {
            InitializeComponent();
            this.idOrden = idOrden;
        }

        private void EditarOrden_Load(object sender, EventArgs e)
        {
            txtIdOrden.Enabled = false;

            CargarClientes();
            CargarTipoServicio();
            CargarEstatus();
            CargarOrden();
        }

        private void CargarClientes()
        {
            string query = @"
SELECT IdCliente, NombreCliente
FROM Cliente
ORDER BY NombreCliente";

            cmbCliente.DataSource = Consultas.Consultar(query, null);
            cmbCliente.DisplayMember = "NombreCliente";
            cmbCliente.ValueMember = "IdCliente";
        }

        private void CargarTipoServicio()
        {
            string query = @"
SELECT IdTipoServicio, NombreTipoServicio
FROM TipoServicio
ORDER BY NombreTipoServicio";

            cmbTipoServicio.DataSource = Consultas.Consultar(query, null);
            cmbTipoServicio.DisplayMember = "NombreTipoServicio";
            cmbTipoServicio.ValueMember = "IdTipoServicio";
        }

        private void CargarEstatus()
        {
            cmbEstatus.Items.Clear();
            cmbEstatus.Items.Add("Registrada");
            cmbEstatus.Items.Add("Pendiente");
            cmbEstatus.Items.Add("En proceso");
            cmbEstatus.Items.Add("Terminada");
            cmbEstatus.Items.Add("Cancelada");
        }

        private void CargarOrden()
        {
            string query = @"
SELECT *
FROM OrdenServicio
WHERE IdOrden = @IdOrden";

            var parametros = new Dictionary<string, object>
            {
                { "@IdOrden", idOrden }
            };

            DataTable dt = Consultas.Consultar(query, parametros);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la orden.");
                Close();
                return;
            }

            DataRow row = dt.Rows[0];

            txtIdOrden.Text = row["IdOrden"].ToString();

            cmbCliente.SelectedValue = Convert.ToInt32(row["IdCliente"]);
            cmbTipoServicio.SelectedValue = Convert.ToInt32(row["IdTipoServicio"]);

            dtpFechaServicio.Value = Convert.ToDateTime(row["FechaServicio"]);

            txtObjetoServicio.Text = row["ObjetoServicio"].ToString();
            txtMarca.Text = row["Marca"].ToString();
            txtModelo.Text = row["Modelo"].ToString();
            txtSerie.Text = row["Serie"].ToString();

            txtFallaReportada.Text = row["FallaReportada"].ToString();
            txtTrabajoSolicitado.Text = row["TrabajoSolicitado"].ToString();
            txtTecnico.Text = row["Tecnico"].ToString();
            txtObservaciones.Text = row["Observaciones"].ToString();

            cmbEstatus.Text = row["Estatus"].ToString();
            chkFacturado.Checked = Convert.ToBoolean(row["Facturado"]);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarOrden();
        }

        private void ActualizarOrden()
        {
            string query = @"
UPDATE OrdenServicio SET
    IdCliente = @IdCliente,
    IdTipoServicio = @IdTipoServicio,
    FechaServicio = @FechaServicio,
    ObjetoServicio = @ObjetoServicio,
    Marca = @Marca,
    Modelo = @Modelo,
    Serie = @Serie,
    FallaReportada = @FallaReportada,
    TrabajoSolicitado = @TrabajoSolicitado,
    Tecnico = @Tecnico,
    Observaciones = @Observaciones,
    Estatus = @Estatus,
    Facturado = @Facturado
WHERE IdOrden = @IdOrden";

            var parametros = new Dictionary<string, object>
            {
                { "@IdOrden", idOrden },
                { "@IdCliente", cmbCliente.SelectedValue },
                { "@IdTipoServicio", cmbTipoServicio.SelectedValue },
                { "@FechaServicio", dtpFechaServicio.Value },
                { "@ObjetoServicio", txtObjetoServicio.Text.Trim() },
                { "@Marca", txtMarca.Text.Trim() },
                { "@Modelo", txtModelo.Text.Trim() },
                { "@Serie", txtSerie.Text.Trim() },
                { "@FallaReportada", txtFallaReportada.Text.Trim() },
                { "@TrabajoSolicitado", txtTrabajoSolicitado.Text.Trim() },
                { "@Tecnico", txtTecnico.Text.Trim() },
                { "@Observaciones", txtObservaciones.Text.Trim() },
                { "@Estatus", cmbEstatus.Text },
                { "@Facturado", chkFacturado.Checked }
            };

            int resultado = Consultas.Ejecutar(query, parametros);

            if (resultado > 0)
            {
                MessageBox.Show("Orden actualizada correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la orden.");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
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
                string rutaLogo = Path.Combine(Application.StartupPath, "PC Solucio blanco.png");

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
                                if (File.Exists(rutaLogo))
                                {
                                    rowHeader.ConstantItem(110)
                                        .Height(65)
                                        .Image(rutaLogo)
                                        .FitArea();
                                }
                                else
                                {
                                    rowHeader.ConstantItem(110);
                                }

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
                                rowPdf.RelativeItem()
                                    .Text($"Folio: OS-{Convert.ToInt32(row["IdOrden"]):00000}")
                                    .Bold();

                                rowPdf.RelativeItem()
                                    .AlignRight()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}