
namespace farmatown.Vistas
{
    partial class FrmReportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.facturasObraSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataVistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataVista = new farmatown.DataVista();
            this.articulosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmatown3DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosVendidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesfrecuentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosVendidosTableAdapter = new farmatown.DataVistaTableAdapters.articulosVendidosTableAdapter();
            this.clientes_frecuentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientes_frecuentesTableAdapter = new farmatown.DataVistaTableAdapters.clientes_frecuentesTableAdapter();
            this.clientesfrecuentesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataVistaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facturasObraSocialTableAdapter = new farmatown.DataVistaTableAdapters.facturasObraSocialTableAdapter();
            this.farmatown3DataSet = new farmatown.farmatown3DataSet();
            this.farmatown3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_vendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facturasObraSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosMasVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_frecuentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVistaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // facturasObraSocialBindingSource
            // 
            this.facturasObraSocialBindingSource.DataMember = "facturasObraSocial";
            this.facturasObraSocialBindingSource.DataSource = this.dataVistaBindingSource;
            // 
            // dataVistaBindingSource
            // 
            this.dataVistaBindingSource.DataSource = this.dataVista;
            this.dataVistaBindingSource.Position = 0;
            // 
            // dataVista
            // 
            this.dataVista.DataSetName = "DataVista";
            this.dataVista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosMasVendidosBindingSource
            // 
            this.articulosMasVendidosBindingSource.DataMember = "articulosMasVendidos";
            // 
            // articulosVendidosBindingSource1
            // 
            this.articulosVendidosBindingSource1.DataMember = "articulosVendidos";
            this.articulosVendidosBindingSource1.DataSource = this.dataVistaBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.facturasObraSocialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "farmatown.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 482);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // clientesfrecuentesBindingSource
            // 
            this.clientesfrecuentesBindingSource.DataMember = "clientes_frecuentes";
            this.clientesfrecuentesBindingSource.DataSource = this.dataVista;
            // 
            // articulosVendidosBindingSource
            // 
            this.articulosVendidosBindingSource.DataMember = "articulosVendidos";
            this.articulosVendidosBindingSource.DataSource = this.dataVista;
            // 
            // articulosVendidosTableAdapter
            // 
            this.articulosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // clientes_frecuentesBindingSource
            // 
            this.clientes_frecuentesBindingSource.DataMember = "clientes_frecuentes";
            this.clientes_frecuentesBindingSource.DataSource = this.dataVista;
            // 
            // clientes_frecuentesTableAdapter
            // 
            this.clientes_frecuentesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesfrecuentesBindingSource1
            // 
            this.clientesfrecuentesBindingSource1.DataMember = "clientes_frecuentes";
            this.clientesfrecuentesBindingSource1.DataSource = this.dataVista;
            // 
            // dataVistaBindingSource1
            // 
            this.dataVistaBindingSource1.DataSource = this.dataVista;
            this.dataVistaBindingSource1.Position = 0;
            // 
            // facturasObraSocialTableAdapter
            // 
            this.facturasObraSocialTableAdapter.ClearBeforeFill = true;
            // 
            // farmatown3DataSet
            // 
            this.farmatown3DataSet.DataSetName = "farmatown3DataSet";
            this.farmatown3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // farmatown3DataSetBindingSource
            // 
            this.farmatown3DataSetBindingSource.DataSource = this.farmatown3DataSet;
            this.farmatown3DataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpClientes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 514);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas según Obra Social";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvArticulos);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artículos más vendidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulo,
            this.cantidad_vendida,
            this.mes,
            this.anio});
            this.dgvArticulos.Location = new System.Drawing.Point(6, 81);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(445, 228);
            this.dgvArticulos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes";
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMes.Location = new System.Drawing.Point(6, 19);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 21);
            this.cboMes.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(133, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte de artículos más vendidos";
            // 
            // tpClientes
            // 
            this.tpClientes.Controls.Add(this.dgvClientes);
            this.tpClientes.Controls.Add(this.label2);
            this.tpClientes.Location = new System.Drawing.Point(4, 22);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(803, 488);
            this.tpClientes.TabIndex = 2;
            this.tpClientes.Text = "Clientes frecuentes";
            this.tpClientes.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.ventas});
            this.dgvClientes.Location = new System.Drawing.Point(8, 28);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(244, 166);
            this.dgvClientes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reporte de clientes más frecuentes";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // ventas
            // 
            this.ventas.HeaderText = "Ventas";
            this.ventas.Name = "ventas";
            this.ventas.ReadOnly = true;
            // 
            // articulo
            // 
            this.articulo.HeaderText = "Articulo";
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            // 
            // cantidad_vendida
            // 
            this.cantidad_vendida.HeaderText = "Cantidad Vendida";
            this.cantidad_vendida.Name = "cantidad_vendida";
            this.cantidad_vendida.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 514);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportes";
            this.Text = "FromReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasObraSocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosMasVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_frecuentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVistaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            this.tpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource farmatown3DataSet1BindingSource;

        private System.Windows.Forms.BindingSource articulosMasVendidosBindingSource;
        private DataVista dataVista;
        private System.Windows.Forms.BindingSource articulosVendidosBindingSource;
        private DataVistaTableAdapters.articulosVendidosTableAdapter articulosVendidosTableAdapter;
        private System.Windows.Forms.BindingSource clientes_frecuentesBindingSource;
        private System.Windows.Forms.BindingSource clientesfrecuentesBindingSource;
        private DataVistaTableAdapters.clientes_frecuentesTableAdapter clientes_frecuentesTableAdapter;
        private System.Windows.Forms.BindingSource clientesfrecuentesBindingSource1;
        private System.Windows.Forms.BindingSource articulosVendidosBindingSource1;
        private System.Windows.Forms.BindingSource dataVistaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource farmatown3DataSetBindingSource;
        private farmatown3DataSet farmatown3DataSet;
        private System.Windows.Forms.BindingSource dataVistaBindingSource1;
        private System.Windows.Forms.BindingSource facturasObraSocialBindingSource;
        private DataVistaTableAdapters.facturasObraSocialTableAdapter facturasObraSocialTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_vendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
    }
}