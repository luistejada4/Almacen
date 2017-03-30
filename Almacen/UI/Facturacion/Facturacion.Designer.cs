namespace AlmacenLT
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxFactura = new System.Windows.Forms.GroupBox();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.groupBoxInicial = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxInicial = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxFormaDePago = new System.Windows.Forms.ComboBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.maskedTextBoxId = new System.Windows.Forms.MaskedTextBox();
            this.statusRegistrarCliente = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelHaciendo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.groupBoxBotones.SuspendLayout();
            this.groupBoxTotal.SuspendLayout();
            this.groupBoxFactura.SuspendLayout();
            this.groupBoxInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusRegistrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBoxBotones);
            this.panel1.Controls.Add(this.groupBoxTotal);
            this.panel1.Controls.Add(this.groupBoxFactura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 465);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.buttonImprimir);
            this.groupBoxBotones.Controls.Add(this.buttonEliminar);
            this.groupBoxBotones.Controls.Add(this.buttonGuardar);
            this.groupBoxBotones.Controls.Add(this.buttonNuevo);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxBotones.Location = new System.Drawing.Point(147, 328);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(333, 135);
            this.groupBoxBotones.TabIndex = 16;
            this.groupBoxBotones.TabStop = false;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(249, 12);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 35);
            this.buttonImprimir.TabIndex = 40;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(168, 12);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 35);
            this.buttonEliminar.TabIndex = 13;
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
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(87, 12);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGuardar.Size = new System.Drawing.Size(75, 35);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevo.Location = new System.Drawing.Point(6, 12);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 35);
            this.buttonNuevo.TabIndex = 12;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Controls.Add(this.labelTotal);
            this.groupBoxTotal.Controls.Add(this.label2);
            this.groupBoxTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxTotal.Location = new System.Drawing.Point(480, 328);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(197, 135);
            this.groupBoxTotal.TabIndex = 15;
            this.groupBoxTotal.TabStop = false;
            this.groupBoxTotal.Enter += new System.EventHandler(this.groupBoxTotal_Enter);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Green;
            this.labelTotal.Location = new System.Drawing.Point(80, 16);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 22);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total";
            // 
            // groupBoxFactura
            // 
            this.groupBoxFactura.Controls.Add(this.buttonPagar);
            this.groupBoxFactura.Controls.Add(this.groupBoxInicial);
            this.groupBoxFactura.Controls.Add(this.label9);
            this.groupBoxFactura.Controls.Add(this.comboBoxFormaDePago);
            this.groupBoxFactura.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxFactura.Controls.Add(this.buttonAgregarProducto);
            this.groupBoxFactura.Controls.Add(this.label8);
            this.groupBoxFactura.Controls.Add(this.comboBoxProductos);
            this.groupBoxFactura.Controls.Add(this.label7);
            this.groupBoxFactura.Controls.Add(this.label6);
            this.groupBoxFactura.Controls.Add(this.label5);
            this.groupBoxFactura.Controls.Add(this.dataGridView);
            this.groupBoxFactura.Controls.Add(this.dateTimePicker1);
            this.groupBoxFactura.Controls.Add(this.textBoxNombre);
            this.groupBoxFactura.Controls.Add(this.buttonBuscar);
            this.groupBoxFactura.Controls.Add(this.maskedTextBoxId);
            this.groupBoxFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFactura.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFactura.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxFactura.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFactura.Name = "groupBoxFactura";
            this.groupBoxFactura.Size = new System.Drawing.Size(677, 328);
            this.groupBoxFactura.TabIndex = 13;
            this.groupBoxFactura.TabStop = false;
            this.groupBoxFactura.Text = "Facturacion";
            // 
            // buttonPagar
            // 
            this.buttonPagar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPagar.Location = new System.Drawing.Point(435, 19);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(75, 35);
            this.buttonPagar.TabIndex = 41;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // groupBoxInicial
            // 
            this.groupBoxInicial.Controls.Add(this.label3);
            this.groupBoxInicial.Controls.Add(this.maskedTextBoxInicial);
            this.groupBoxInicial.Location = new System.Drawing.Point(372, 76);
            this.groupBoxInicial.Name = "groupBoxInicial";
            this.groupBoxInicial.Size = new System.Drawing.Size(179, 62);
            this.groupBoxInicial.TabIndex = 42;
            this.groupBoxInicial.TabStop = false;
            this.groupBoxInicial.Text = "Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Monto";
            // 
            // maskedTextBoxInicial
            // 
            this.maskedTextBoxInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxInicial.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxInicial.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBoxInicial.Location = new System.Drawing.Point(63, 33);
            this.maskedTextBoxInicial.Mask = "9999999999";
            this.maskedTextBoxInicial.Name = "maskedTextBoxInicial";
            this.maskedTextBoxInicial.Size = new System.Drawing.Size(112, 25);
            this.maskedTextBoxInicial.TabIndex = 40;
            this.maskedTextBoxInicial.Text = "0";
            this.maskedTextBoxInicial.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "Forma de pago";
            // 
            // comboBoxFormaDePago
            // 
            this.comboBoxFormaDePago.FormattingEnabled = true;
            this.comboBoxFormaDePago.Location = new System.Drawing.Point(127, 112);
            this.comboBoxFormaDePago.Name = "comboBoxFormaDePago";
            this.comboBoxFormaDePago.Size = new System.Drawing.Size(239, 26);
            this.comboBoxFormaDePago.TabIndex = 38;
            this.comboBoxFormaDePago.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaDePago_SelectedIndexChanged);
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDownCantidad.Location = new System.Drawing.Point(380, 144);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(42, 26);
            this.numericUpDownCantidad.TabIndex = 37;
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarProducto.Location = new System.Drawing.Point(433, 139);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(75, 35);
            this.buttonAgregarProducto.TabIndex = 14;
            this.buttonAgregarProducto.Text = "Agregar";
            this.buttonAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(42, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 36;
            this.label8.Text = "Producto";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(127, 143);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(239, 26);
            this.comboBoxProductos.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(66, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(59, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(35, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Factura Id";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductoId,
            this.ColumnProducto,
            this.ColumnNombre,
            this.ColumnPrecio,
            this.ColumnSubTotal});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(3, 175);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.Size = new System.Drawing.Size(671, 150);
            this.dataGridView.TabIndex = 32;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // ColumnProductoId
            // 
            this.ColumnProductoId.HeaderText = "ProductoId";
            this.ColumnProductoId.Name = "ColumnProductoId";
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            this.ColumnProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnProducto.ToolTipText = "Elige un producto";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Cantidad";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnSubTotal
            // 
            this.ColumnSubTotal.HeaderText = "SubTotal";
            this.ColumnSubTotal.Name = "ColumnSubTotal";
            this.ColumnSubTotal.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombre.Location = new System.Drawing.Point(127, 54);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(239, 23);
            this.textBoxNombre.TabIndex = 13;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(385, 23);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(29, 25);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // maskedTextBoxId
            // 
            this.maskedTextBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxId.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxId.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBoxId.Location = new System.Drawing.Point(127, 23);
            this.maskedTextBoxId.Mask = "9999999999";
            this.maskedTextBoxId.Name = "maskedTextBoxId";
            this.maskedTextBoxId.Size = new System.Drawing.Size(239, 25);
            this.maskedTextBoxId.TabIndex = 11;
            this.maskedTextBoxId.ValidatingType = typeof(int);
            // 
            // statusRegistrarCliente
            // 
            this.statusRegistrarCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelEstado,
            this.toolStripLabelHaciendo});
            this.statusRegistrarCliente.Location = new System.Drawing.Point(0, 443);
            this.statusRegistrarCliente.Name = "statusRegistrarCliente";
            this.statusRegistrarCliente.Size = new System.Drawing.Size(679, 22);
            this.statusRegistrarCliente.TabIndex = 3;
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
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 465);
            this.Controls.Add(this.statusRegistrarCliente);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlmacenLT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxBotones.ResumeLayout(false);
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            this.groupBoxFactura.ResumeLayout(false);
            this.groupBoxFactura.PerformLayout();
            this.groupBoxInicial.ResumeLayout(false);
            this.groupBoxInicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusRegistrarCliente.ResumeLayout(false);
            this.statusRegistrarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxId;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.StatusStrip statusRegistrarCliente;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelHaciendo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxFormaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubTotal;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInicial;
        private System.Windows.Forms.GroupBox groupBoxInicial;
        private System.Windows.Forms.Button buttonPagar;
    }
}

