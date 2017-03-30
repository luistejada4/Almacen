namespace AlmacenLT.UI.Registros
{
    partial class RegistrarCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCliente));
            this.maskedTextBoxId = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxRutas = new System.Windows.Forms.ComboBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCedula = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusRegistrarCliente = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelHaciendo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerEscribiendo = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusRegistrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxId
            // 
            this.maskedTextBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxId.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxId.ForeColor = System.Drawing.Color.DimGray;
            this.maskedTextBoxId.Location = new System.Drawing.Point(91, 24);
            this.maskedTextBoxId.Mask = "9999999999";
            this.maskedTextBoxId.Name = "maskedTextBoxId";
            this.maskedTextBoxId.Size = new System.Drawing.Size(137, 25);
            this.maskedTextBoxId.TabIndex = 1;
            this.maskedTextBoxId.ValidatingType = typeof(int);
            this.maskedTextBoxId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombre.Location = new System.Drawing.Point(91, 55);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(237, 23);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // comboBoxRutas
            // 
            this.comboBoxRutas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRutas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRutas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRutas.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxRutas.FormattingEnabled = true;
            this.comboBoxRutas.Location = new System.Drawing.Point(91, 85);
            this.comboBoxRutas.Name = "comboBoxRutas";
            this.comboBoxRutas.Size = new System.Drawing.Size(237, 29);
            this.comboBoxRutas.TabIndex = 4;
            this.comboBoxRutas.Text = "Seleccione una ruta";
            this.comboBoxRutas.ValueMemberChanged += new System.EventHandler(this.timer_TerminoDeEscribir);
            this.comboBoxRutas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDireccion.Location = new System.Drawing.Point(91, 120);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(237, 57);
            this.textBoxDireccion.TabIndex = 5;
            this.textBoxDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // maskedTextBoxTelefono
            // 
            this.maskedTextBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxTelefono.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.maskedTextBoxTelefono.Location = new System.Drawing.Point(91, 183);
            this.maskedTextBoxTelefono.Mask = "999-999-9999";
            this.maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            this.maskedTextBoxTelefono.Size = new System.Drawing.Size(237, 23);
            this.maskedTextBoxTelefono.TabIndex = 6;
            this.maskedTextBoxTelefono.ValidatingType = typeof(int);
            this.maskedTextBoxTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // maskedTextBoxCedula
            // 
            this.maskedTextBoxCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxCedula.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCedula.ForeColor = System.Drawing.Color.DimGray;
            this.maskedTextBoxCedula.Location = new System.Drawing.Point(91, 212);
            this.maskedTextBoxCedula.Mask = "999-999999-9";
            this.maskedTextBoxCedula.Name = "maskedTextBoxCedula";
            this.maskedTextBoxCedula.Size = new System.Drawing.Size(237, 23);
            this.maskedTextBoxCedula.TabIndex = 7;
            this.maskedTextBoxCedula.ValidatingType = typeof(int);
            this.maskedTextBoxCedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.maskedTextBoxId);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.maskedTextBoxCedula);
            this.groupBox1.Controls.Add(this.comboBoxRutas);
            this.groupBox1.Controls.Add(this.maskedTextBoxTelefono);
            this.groupBox1.Controls.Add(this.buttonNuevo);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(253, 24);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(29, 25);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.Image = global::Almacen.Properties.Resources.Delete_20;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(253, 241);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 35);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGuardar.Image = global::Almacen.Properties.Resources.Save_20;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(172, 241);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGuardar.Size = new System.Drawing.Size(75, 35);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNuevo.Image = global::Almacen.Properties.Resources.Create_New_20;
            this.buttonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevo.Location = new System.Drawing.Point(91, 241);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 35);
            this.buttonNuevo.TabIndex = 9;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // statusRegistrarCliente
            // 
            this.statusRegistrarCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelEstado,
            this.toolStripLabelHaciendo});
            this.statusRegistrarCliente.Location = new System.Drawing.Point(0, 327);
            this.statusRegistrarCliente.Name = "statusRegistrarCliente";
            this.statusRegistrarCliente.Size = new System.Drawing.Size(379, 22);
            this.statusRegistrarCliente.TabIndex = 1;
            this.statusRegistrarCliente.Text = "statusStrip1";
            // 
            // toolStripLabelEstado
            // 
            this.toolStripLabelEstado.Name = "toolStripLabelEstado";
            this.toolStripLabelEstado.Size = new System.Drawing.Size(45, 17);
            this.toolStripLabelEstado.Text = "Estado:";
            // 
            // toolStripLabelHaciendo
            // 
            this.toolStripLabelHaciendo.Name = "toolStripLabelHaciendo";
            this.toolStripLabelHaciendo.Size = new System.Drawing.Size(54, 17);
            this.toolStripLabelHaciendo.Text = "Ninguno";
            // 
            // timerEscribiendo
            // 
            this.timerEscribiendo.Interval = 1000;
            this.timerEscribiendo.Tick += new System.EventHandler(this.timer_TerminoDeEscribir);
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 349);
            this.Controls.Add(this.statusRegistrarCliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar cliente";
            this.Load += new System.EventHandler(this.RegistrarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusRegistrarCliente.ResumeLayout(false);
            this.statusRegistrarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxRutas;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefono;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCedula;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusRegistrarCliente;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelHaciendo;
        private System.Windows.Forms.Timer timerEscribiendo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}