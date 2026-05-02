namespace RegistroServicio
{
    partial class TipoServicio
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
            groupBox1 = new GroupBox();
            rbActivo = new RadioButton();
            rbInactivo = new RadioButton();
            label1 = new Label();
            txtNombreTipoServicio = new TextBox();
            Folio = new Label();
            txtIdTipoServicio = new TextBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dgvTipoServicio = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoServicio).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbActivo);
            groupBox1.Controls.Add(rbInactivo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombreTipoServicio);
            groupBox1.Controls.Add(Folio);
            groupBox1.Controls.Add(txtIdTipoServicio);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbActivo
            // 
            rbActivo.AutoSize = true;
            rbActivo.Location = new Point(648, 34);
            rbActivo.Name = "rbActivo";
            rbActivo.Size = new Size(90, 28);
            rbActivo.TabIndex = 5;
            rbActivo.TabStop = true;
            rbActivo.Text = "Activo";
            rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbInactivo
            // 
            rbInactivo.AutoSize = true;
            rbInactivo.Location = new Point(648, 94);
            rbInactivo.Name = "rbInactivo";
            rbInactivo.Size = new Size(105, 28);
            rbInactivo.TabIndex = 4;
            rbInactivo.TabStop = true;
            rbInactivo.Text = "Inactivo";
            rbInactivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 103);
            label1.Name = "label1";
            label1.Size = new Size(163, 24);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Servicio";
            // 
            // txtNombreTipoServicio
            // 
            txtNombreTipoServicio.Location = new Point(199, 103);
            txtNombreTipoServicio.Name = "txtNombreTipoServicio";
            txtNombreTipoServicio.Size = new Size(246, 30);
            txtNombreTipoServicio.TabIndex = 2;
            // 
            // Folio
            // 
            Folio.AutoSize = true;
            Folio.Location = new Point(64, 33);
            Folio.Name = "Folio";
            Folio.Size = new Size(56, 24);
            Folio.TabIndex = 1;
            Folio.Text = "Folio";
            // 
            // txtIdTipoServicio
            // 
            txtIdTipoServicio.Location = new Point(199, 33);
            txtIdTipoServicio.Name = "txtIdTipoServicio";
            txtIdTipoServicio.Size = new Size(125, 30);
            txtIdTipoServicio.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(166, 195);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(556, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Canncelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(351, 195);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(49, 195);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button4_Click;
            // 
            // dgvTipoServicio
            // 
            dgvTipoServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoServicio.Location = new Point(24, 251);
            dgvTipoServicio.Name = "dgvTipoServicio";
            dgvTipoServicio.RowHeadersWidth = 51;
            dgvTipoServicio.Size = new Size(980, 422);
            dgvTipoServicio.TabIndex = 10;
            // 
            // TipoServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 666);
            Controls.Add(dgvTipoServicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox1);
            Name = "TipoServicio";
            Text = "TipoServicio";
            Load += TipoServicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoServicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label Folio;
        private TextBox txtIdTipoServicio;
        private Label label1;
        private TextBox txtNombreTipoServicio;
        private RadioButton rbActivo;
        private RadioButton rbInactivo;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvTipoServicio;
    }
}