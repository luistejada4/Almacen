﻿namespace AlmacenLT.UI.Consultas
{
    partial class ConsultarRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarRutas));
            this.statusRegistrarCliente = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelHaciendo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.comboBoxRutas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.statusRegistrarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusRegistrarCliente
            // 
            this.statusRegistrarCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelEstado,
            this.toolStripLabelHaciendo,
            this.toolStripProgressBar});
            this.statusRegistrarCliente.Location = new System.Drawing.Point(0, 544);
            this.statusRegistrarCliente.Name = "statusRegistrarCliente";
            this.statusRegistrarCliente.Size = new System.Drawing.Size(366, 22);
            this.statusRegistrarCliente.TabIndex = 34;
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
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Value = 1;
            // 
            // comboBoxRutas
            // 
            this.comboBoxRutas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRutas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRutas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRutas.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxRutas.FormattingEnabled = true;
            this.comboBoxRutas.Location = new System.Drawing.Point(53, 26);
            this.comboBoxRutas.Name = "comboBoxRutas";
            this.comboBoxRutas.Size = new System.Drawing.Size(237, 29);
            this.comboBoxRutas.TabIndex = 36;
            this.comboBoxRutas.Text = "Seleccione una ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ruta";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(296, 30);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(29, 25);
            this.buttonBuscar.TabIndex = 39;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCliente,
            this.Direccion});
            this.dataGridView1.Location = new System.Drawing.Point(22, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 350);
            this.dataGridView1.TabIndex = 40;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxRutas);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 62);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar ruta";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(65, 464);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(154, 36);
            this.buttonImprimir.TabIndex = 42;
            this.buttonImprimir.Text = "Ver reporte";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // ConsultarRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 566);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusRegistrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarRutas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultarRutas";
            this.Load += new System.EventHandler(this.ConsultarRutas_Load);
            this.statusRegistrarCliente.ResumeLayout(false);
            this.statusRegistrarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusRegistrarCliente;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelHaciendo;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ComboBox comboBoxRutas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button buttonImprimir;
    }
}