namespace RegistroServicio
{
    partial class OrdenServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIdOrden = new TextBox();
            dtpFechaServicio = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnAgregarCliente = new Button();
            btnAgregarTipoServicio = new Button();
            chkFacturado = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            cbTipoServicio = new ComboBox();
            cbCliente = new ComboBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtSerie = new TextBox();
            label8 = new Label();
            txtMarca = new TextBox();
            label7 = new Label();
            txtModelo = new TextBox();
            label6 = new Label();
            txtObjetoServicio = new TextBox();
            Falla = new GroupBox();
            label11 = new Label();
            txtTrabajoSolicitado = new TextBox();
            label10 = new Label();
            txtFallaReportada = new TextBox();
            groupBox4 = new GroupBox();
            label13 = new Label();
            cbEstatus = new ComboBox();
            label12 = new Label();
            txtTecnico = new TextBox();
            label14 = new Label();
            txtObservaciones = new TextBox();
            btnNuevo = new Button();
            btnCerrar = new Button();
            btnImprimir = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            Falla.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 55);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 0;
            label1.Text = "Folio";
            // 
            // txtIdOrden
            // 
            txtIdOrden.Location = new Point(109, 49);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(95, 30);
            txtIdOrden.TabIndex = 1;
            // 
            // dtpFechaServicio
            // 
            dtpFechaServicio.Location = new Point(433, 47);
            dtpFechaServicio.Name = "dtpFechaServicio";
            dtpFechaServicio.Size = new Size(250, 30);
            dtpFechaServicio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 52);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 3;
            label2.Text = "Fecha Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 9);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 4;
            label3.Text = "Orden de Servicio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaServicio);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdOrden);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1286, 109);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orden de Servicio";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregarCliente);
            groupBox2.Controls.Add(btnAgregarTipoServicio);
            groupBox2.Controls.Add(chkFacturado);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbTipoServicio);
            groupBox2.Controls.Add(cbCliente);
            groupBox2.Location = new Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1104, 147);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente y tipo de servicio";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(861, 46);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(94, 56);
            btnAgregarCliente.TabIndex = 8;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTipoServicio
            // 
            btnAgregarTipoServicio.Location = new Point(972, 46);
            btnAgregarTipoServicio.Name = "btnAgregarTipoServicio";
            btnAgregarTipoServicio.Size = new Size(115, 85);
            btnAgregarTipoServicio.TabIndex = 7;
            btnAgregarTipoServicio.Text = "Agregar Tipo de Servicio";
            btnAgregarTipoServicio.UseVisualStyleBackColor = true;
            // 
            // chkFacturado
            // 
            chkFacturado.AutoSize = true;
            chkFacturado.Location = new Point(701, 104);
            chkFacturado.Name = "chkFacturado";
            chkFacturado.Size = new Size(110, 28);
            chkFacturado.TabIndex = 6;
            chkFacturado.Text = "Facturado";
            chkFacturado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 46);
            label4.Name = "label4";
            label4.Size = new Size(63, 24);
            label4.TabIndex = 4;
            label4.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 54);
            label5.Name = "label5";
            label5.Size = new Size(72, 24);
            label5.TabIndex = 5;
            label5.Text = "Servicio";
            // 
            // cbTipoServicio
            // 
            cbTipoServicio.FormattingEnabled = true;
            cbTipoServicio.Location = new Point(591, 46);
            cbTipoServicio.Name = "cbTipoServicio";
            cbTipoServicio.Size = new Size(247, 32);
            cbTipoServicio.TabIndex = 1;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(109, 46);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(292, 32);
            cbCliente.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtSerie);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtMarca);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtModelo);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtObjetoServicio);
            groupBox3.Location = new Point(12, 325);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(967, 170);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Objeto del Servicio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(501, 117);
            label9.Name = "label9";
            label9.Size = new Size(49, 24);
            label9.TabIndex = 10;
            label9.Text = "Serie";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(685, 111);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(260, 30);
            txtSerie.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(501, 48);
            label8.Name = "label8";
            label8.Size = new Size(57, 24);
            label8.TabIndex = 8;
            label8.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(685, 42);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(260, 30);
            txtMarca.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 123);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 6;
            label7.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(206, 117);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(260, 30);
            txtModelo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 61);
            label6.Name = "label6";
            label6.Size = new Size(156, 24);
            label6.TabIndex = 4;
            label6.Text = "Objeto del Servicio";
            // 
            // txtObjetoServicio
            // 
            txtObjetoServicio.Location = new Point(206, 55);
            txtObjetoServicio.Name = "txtObjetoServicio";
            txtObjetoServicio.Size = new Size(260, 30);
            txtObjetoServicio.TabIndex = 5;
            // 
            // Falla
            // 
            Falla.Controls.Add(label11);
            Falla.Controls.Add(txtTrabajoSolicitado);
            Falla.Controls.Add(label10);
            Falla.Controls.Add(txtFallaReportada);
            Falla.Location = new Point(12, 520);
            Falla.Name = "Falla";
            Falla.Size = new Size(693, 190);
            Falla.TabIndex = 12;
            Falla.TabStop = false;
            Falla.Text = "Falla";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(270, 26);
            label11.Name = "label11";
            label11.Size = new Size(148, 24);
            label11.TabIndex = 14;
            label11.Text = "Trabajo Realizado";
            // 
            // txtTrabajoSolicitado
            // 
            txtTrabajoSolicitado.Location = new Point(270, 91);
            txtTrabajoSolicitado.Name = "txtTrabajoSolicitado";
            txtTrabajoSolicitado.Size = new Size(200, 30);
            txtTrabajoSolicitado.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 35);
            label10.Name = "label10";
            label10.Size = new Size(131, 24);
            label10.TabIndex = 12;
            label10.Text = "Falla Reportada";
            // 
            // txtFallaReportada
            // 
            txtFallaReportada.Location = new Point(4, 100);
            txtFallaReportada.Name = "txtFallaReportada";
            txtFallaReportada.Size = new Size(200, 30);
            txtFallaReportada.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(cbEstatus);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtTecnico);
            groupBox4.Location = new Point(16, 733);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(834, 121);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = ".";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(361, 58);
            label13.Name = "label13";
            label13.Size = new Size(68, 24);
            label13.TabIndex = 10;
            label13.Text = "Estatus";
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Location = new Point(448, 58);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(292, 32);
            cbEstatus.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 61);
            label12.Name = "label12";
            label12.Size = new Size(66, 24);
            label12.TabIndex = 16;
            label12.Text = "técnico";
            // 
            // txtTecnico
            // 
            txtTecnico.Location = new Point(90, 58);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(239, 30);
            txtTecnico.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 919);
            label14.Name = "label14";
            label14.Size = new Size(126, 24);
            label14.TabIndex = 19;
            label14.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(191, 916);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(412, 30);
            txtObservaciones.TabIndex = 20;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(912, 860);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 21;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1032, 860);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 22;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(1032, 914);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 23;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(912, 961);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Éditar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(912, 914);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // OrdenServicio
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 1055);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnImprimir);
            Controls.Add(btnCerrar);
            Controls.Add(btnNuevo);
            Controls.Add(txtObservaciones);
            Controls.Add(label14);
            Controls.Add(groupBox4);
            Controls.Add(Falla);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "OrdenServicio";
            Text = "OrdenServicio";
            Load += OrdenServicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            Falla.ResumeLayout(false);
            Falla.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdOrden;
        private DateTimePicker dtpFechaServicio;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private ComboBox cbTipoServicio;
        private ComboBox cbCliente;
        private Button btnAgregarCliente;
        private Button btnAgregarTipoServicio;
        private CheckBox chkFacturado;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox txtObjetoServicio;
        private Label label9;
        private TextBox txtSerie;
        private Label label8;
        private TextBox txtMarca;
        private Label label7;
        private TextBox txtModelo;
        private GroupBox Falla;
        private Label label11;
        private TextBox txtTrabajoSolicitado;
        private Label label10;
        private TextBox txtFallaReportada;
        private GroupBox groupBox4;
        private Label label13;
        private ComboBox cbEstatus;
        private Label label12;
        private TextBox txtTecnico;
        private Label label14;
        private TextBox txtObservaciones;
        private Button btnNuevo;
        private Button btnCerrar;
        private Button btnImprimir;
        private Button btnEditar;
        private Button btnGuardar;
    }
}