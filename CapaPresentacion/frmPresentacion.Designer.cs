namespace CapaPresentacion
{
    partial class frmPresentacion
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtCedula = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbGenero = new ComboBox();
            label5 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            dgvDocente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 55);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(185, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 84);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos: ";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(185, 110);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(200, 23);
            txtCedula.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 113);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Cedula: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 142);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Genero: ";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "SELECCIONE", "MASCULINO", "FEMENINO" });
            cmbGenero.Location = new Point(185, 139);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(200, 23);
            cmbGenero.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 170);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha Nacimiento: ";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(185, 168);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(185, 197);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 200);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(185, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(121, 229);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 12;
            label7.Text = "Telefono: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 258);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 14;
            label8.Text = "Estado: ";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "SELECCIONE", "ACTIVO", "INACTIVO" });
            cmbEstado.Location = new Point(186, 258);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(199, 23);
            cmbEstado.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(283, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvDocente
            // 
            dgvDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocente.Location = new Point(437, 54);
            dgvDocente.Name = "dgvDocente";
            dgvDocente.RowTemplate.Height = 25;
            dgvDocente.Size = new Size(460, 256);
            dgvDocente.TabIndex = 17;
            // 
            // frmPresentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 334);
            Controls.Add(dgvDocente);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label5);
            Controls.Add(cmbGenero);
            Controls.Add(label4);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmPresentacion";
            Text = "Docentes";
            ((System.ComponentModel.ISupportInitialize)dgvDocente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtCedula;
        private Label label3;
        private Label label4;
        private ComboBox cmbGenero;
        private Label label5;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtDireccion;
        private Label label6;
        private TextBox txtTelefono;
        private Label label7;
        private Label label8;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private DataGridView dgvDocente;
    }
}