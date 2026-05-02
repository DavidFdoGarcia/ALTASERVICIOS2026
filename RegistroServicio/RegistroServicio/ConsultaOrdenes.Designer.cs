namespace RegistroServicio
{
    partial class ConsultaOrdenes
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
            Button btnCerrar;
            txtBuscar = new TextBox();
            label1 = new Label();
            cmbTipoServicio = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbEstatus = new ComboBox();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            chkSoloNoFacturados = new CheckBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            dgvOrdenes = new DataGridView();
            btnVer = new Button();
            btnImprimir = new Button();
            btnEditar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(512, 625);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(113, 22);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(186, 30);
            txtBuscar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // cmbTipoServicio
            // 
            cmbTipoServicio.FormattingEnabled = true;
            cmbTipoServicio.Location = new Point(200, 77);
            cmbTipoServicio.Name = "cmbTipoServicio";
            cmbTipoServicio.Size = new Size(151, 32);
            cmbTipoServicio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 24);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 5;
            label3.Text = "Estatus";
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Location = new Point(113, 141);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(151, 32);
            cmbEstatus.TabIndex = 4;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(869, 143);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(250, 30);
            dtpFin.TabIndex = 6;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(477, 143);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(250, 30);
            dtpInicio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(765, 148);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 24);
            label4.TabIndex = 8;
            label4.Text = "Fin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 149);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 9;
            label5.Text = "Inicio";
            // 
            // chkSoloNoFacturados
            // 
            chkSoloNoFacturados.AutoSize = true;
            chkSoloNoFacturados.Location = new Point(554, 62);
            chkSoloNoFacturados.Name = "chkSoloNoFacturados";
            chkSoloNoFacturados.Size = new Size(210, 28);
            chkSoloNoFacturados.TabIndex = 10;
            chkSoloNoFacturados.Text = "solo no facturados";
            chkSoloNoFacturados.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(953, 91);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(953, 22);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(29, 208);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.RowHeadersWidth = 51;
            dgvOrdenes.Size = new Size(1046, 340);
            dgvOrdenes.TabIndex = 13;
            dgvOrdenes.CellContentDoubleClick += dgvOrdenes_CellContentDoubleClick;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(29, 630);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(94, 29);
            btnVer.TabIndex = 14;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(257, 630);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 15;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += button2_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(145, 630);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(367, 619);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(124, 40);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Acrualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // ConsultaOrdenes
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1648, 692);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnImprimir);
            Controls.Add(btnVer);
            Controls.Add(dgvOrdenes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(chkSoloNoFacturados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpInicio);
            Controls.Add(dtpFin);
            Controls.Add(label3);
            Controls.Add(cmbEstatus);
            Controls.Add(label2);
            Controls.Add(cmbTipoServicio);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ConsultaOrdenes";
            Text = "ConsultaOrdenes";
            Load += ConsultaOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Label label1;
        private ComboBox cmbTipoServicio;
        private Label label2;
        private Label label3;
        private ComboBox cmbEstatus;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private Label label4;
        private Label label5;
        private CheckBox chkSoloNoFacturados;
        private Button btnBuscar;
        private Button btnLimpiar;
        private DataGridView dgvOrdenes;
        private Button btnVer;
        private Button btnImprimir;
        private Button btnEditar;
        private Button btnCerrar;
        private Button btnActualizar;
    }
}