namespace RegistroServicio
{
    partial class Clientes
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
            txtIdCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtEmpresa = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtDomicilio = new TextBox();
            rbActivo = new RadioButton();
            rbInactivo = new RadioButton();
            dgvClientes = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(93, 32);
            txtIdCliente.Margin = new Padding(5, 4, 5, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(186, 30);
            txtIdCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 24);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 99);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 3;
            label2.Text = "Nombre del Cliente";
            label2.Click += label2_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(245, 96);
            txtNombreCliente.Margin = new Padding(5, 4, 5, 4);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(283, 30);
            txtNombreCliente.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 161);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(245, 161);
            txtTelefono.Margin = new Padding(5, 4, 5, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(283, 30);
            txtTelefono.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 235);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 7;
            label4.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(245, 232);
            txtEmpresa.Margin = new Padding(5, 4, 5, 4);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(283, 30);
            txtEmpresa.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 303);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 24);
            label5.TabIndex = 9;
            label5.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(245, 300);
            txtCorreo.Margin = new Padding(5, 4, 5, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(283, 30);
            txtCorreo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 372);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 24);
            label6.TabIndex = 11;
            label6.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(245, 369);
            txtDomicilio.Margin = new Padding(5, 4, 5, 4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(283, 30);
            txtDomicilio.TabIndex = 10;
            // 
            // rbActivo
            // 
            rbActivo.AutoSize = true;
            rbActivo.Location = new Point(652, 104);
            rbActivo.Name = "rbActivo";
            rbActivo.Size = new Size(90, 28);
            rbActivo.TabIndex = 12;
            rbActivo.TabStop = true;
            rbActivo.Text = "Activo";
            rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbInactivo
            // 
            rbInactivo.AutoSize = true;
            rbInactivo.Location = new Point(637, 197);
            rbInactivo.Name = "rbInactivo";
            rbInactivo.Size = new Size(105, 28);
            rbInactivo.TabIndex = 13;
            rbInactivo.TabStop = true;
            rbInactivo.Text = "Inactivo";
            rbInactivo.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(34, 430);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(1006, 279);
            dgvClientes.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(711, 284);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(711, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(846, 284);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(846, 355);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 721);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvClientes);
            Controls.Add(rbInactivo);
            Controls.Add(rbActivo);
            Controls.Add(label6);
            Controls.Add(txtDomicilio);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtEmpresa);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Controls.Add(txtIdCliente);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCliente;
        private Label label1;
        private Label label2;
        private TextBox txtNombreCliente;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtEmpresa;
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtDomicilio;
        private RadioButton rbActivo;
        private RadioButton rbInactivo;
        private DataGridView dgvClientes;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}