namespace AlmacenLT.UI.Registros
{
    partial class RegistrarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProductos));
            this.statusRegistrarCliente = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelHaciendo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxPrecio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCosto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.maskedTextBoxId = new System.Windows.Forms.MaskedTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerEscribiendo = new System.Windows.Forms.Timer(this.components);
            this.statusRegistrarCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusRegistrarCliente
            // 
            this.statusRegistrarCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelEstado,
            this.toolStripLabelHaciendo});
            this.statusRegistrarCliente.Location = new System.Drawing.Point(0, 278);
            this.statusRegistrarCliente.Name = "statusRegistrarCliente";
            this.statusRegistrarCliente.Size = new System.Drawing.Size(413, 22);
            this.statusRegistrarCliente.TabIndex = 25;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBoxPrecio);
            this.groupBox1.Controls.Add(this.maskedTextBoxCosto);
            this.groupBox1.Controls.Add(this.maskedTextBoxCantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.maskedTextBoxId);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.buttonNuevo);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 241);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Costo";
            // 
            // maskedTextBoxPrecio
            // 
            this.maskedTextBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxPrecio.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPrecio.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBoxPrecio.Location = new System.Drawing.Point(94, 158);
            this.maskedTextBoxPrecio.Mask = "9999999999";
            this.maskedTextBoxPrecio.Name = "maskedTextBoxPrecio";
            this.maskedTextBoxPrecio.Size = new System.Drawing.Size(237, 25);
            this.maskedTextBoxPrecio.TabIndex = 4;
            this.maskedTextBoxPrecio.ValidatingType = typeof(int);
            this.maskedTextBoxPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // maskedTextBoxCosto
            // 
            this.maskedTextBoxCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxCosto.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCosto.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBoxCosto.Location = new System.Drawing.Point(94, 127);
            this.maskedTextBoxCosto.Mask = "9999999999";
            this.maskedTextBoxCosto.Name = "maskedTextBoxCosto";
            this.maskedTextBoxCosto.Size = new System.Drawing.Size(237, 25);
            this.maskedTextBoxCosto.TabIndex = 3;
            this.maskedTextBoxCosto.ValidatingType = typeof(int);
            this.maskedTextBoxCosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // maskedTextBoxCantidad
            // 
            this.maskedTextBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxCantidad.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCantidad.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBoxCantidad.Location = new System.Drawing.Point(94, 96);
            this.maskedTextBoxCantidad.Mask = "9999999999";
            this.maskedTextBoxCantidad.Name = "maskedTextBoxCantidad";
            this.maskedTextBoxCantidad.Size = new System.Drawing.Size(237, 25);
            this.maskedTextBoxCantidad.TabIndex = 2;
            this.maskedTextBoxCantidad.ValidatingType = typeof(int);
            this.maskedTextBoxCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(256, 36);
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
            this.buttonEliminar.Location = new System.Drawing.Point(256, 190);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 35);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // maskedTextBoxId
            // 
            this.maskedTextBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxId.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxId.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBoxId.Location = new System.Drawing.Point(94, 36);
            this.maskedTextBoxId.Mask = "9999999999";
            this.maskedTextBoxId.Name = "maskedTextBoxId";
            this.maskedTextBoxId.Size = new System.Drawing.Size(137, 25);
            this.maskedTextBoxId.TabIndex = 0;
            this.maskedTextBoxId.ValidatingType = typeof(int);
            this.maskedTextBoxId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGuardar.Image = global::Almacen.Properties.Resources.Save_20;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(175, 190);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGuardar.Size = new System.Drawing.Size(75, 35);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombre.Location = new System.Drawing.Point(94, 67);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(237, 23);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNuevo.Image = global::Almacen.Properties.Resources.Create_New_20;
            this.buttonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevo.Location = new System.Drawing.Point(94, 190);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 35);
            this.buttonNuevo.TabIndex = 9;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // timerEscribiendo
            // 
            this.timerEscribiendo.Interval = 1000;
            this.timerEscribiendo.Tick += new System.EventHandler(this.timer_TerminoDeEscribir);
            // 
            // RegistrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 300);
            this.Controls.Add(this.statusRegistrarCliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarProductos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar producto";
            this.Load += new System.EventHandler(this.RegistrarProductos_Load);
            this.statusRegistrarCliente.ResumeLayout(false);
            this.statusRegistrarCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusRegistrarCliente;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelHaciendo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCosto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxId;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timerEscribiendo;
    }
}