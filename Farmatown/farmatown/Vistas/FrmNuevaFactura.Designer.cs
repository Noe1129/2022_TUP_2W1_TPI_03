
namespace farmatown.Vistas
{
    partial class FrmNuevaFactura
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBObraSocial = new System.Windows.Forms.CheckBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboArticulos = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaVto = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDniFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.gbTarjeta = new System.Windows.Forms.GroupBox();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSeguridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.gbTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(918, 482);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 23);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cBObraSocial);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.lblDescuento);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAgregarDetalle);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.cboArticulos);
            this.groupBox1.Controls.Add(this.dgvDetalles);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblNroFactura);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 504);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // cBObraSocial
            // 
            this.cBObraSocial.AutoSize = true;
            this.cBObraSocial.Location = new System.Drawing.Point(603, 114);
            this.cBObraSocial.Name = "cBObraSocial";
            this.cBObraSocial.Size = new System.Drawing.Size(109, 17);
            this.cBObraSocial.TabIndex = 60;
            this.cBObraSocial.Text = "Tiene obra Social";
            this.cBObraSocial.UseVisualStyleBackColor = true;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(744, 94);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 59;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(747, 110);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(89, 20);
            this.txtDescuento.TabIndex = 58;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(458, 110);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(91, 20);
            this.nudCantidad.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Articulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Cantidad";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(890, 108);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(110, 23);
            this.btnAgregarDetalle.TabIndex = 53;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(936, 464);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 12);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "Total $ 0";
            // 
            // cboArticulos
            // 
            this.cboArticulos.FormattingEnabled = true;
            this.cboArticulos.Location = new System.Drawing.Point(28, 110);
            this.cboArticulos.Name = "cboArticulos";
            this.cboArticulos.Size = new System.Drawing.Size(354, 21);
            this.cboArticulos.TabIndex = 49;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ColArticulo,
            this.ColTipoArt,
            this.ColPrecio,
            this.ColCantidad,
            this.colDescuento,
            this.ColTotal,
            this.ColBorrar});
            this.dgvDetalles.Location = new System.Drawing.Point(28, 148);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(1021, 297);
            this.dgvDetalles.TabIndex = 45;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 90;
            // 
            // ColArticulo
            // 
            this.ColArticulo.HeaderText = "Articulo";
            this.ColArticulo.MinimumWidth = 6;
            this.ColArticulo.Name = "ColArticulo";
            this.ColArticulo.ReadOnly = true;
            this.ColArticulo.Width = 200;
            // 
            // ColTipoArt
            // 
            this.ColTipoArt.HeaderText = "Tipo de articulo";
            this.ColTipoArt.Name = "ColTipoArt";
            this.ColTipoArt.ReadOnly = true;
            this.ColTipoArt.Width = 150;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 66;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 75;
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "";
            this.ColBorrar.MinimumWidth = 6;
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.ReadOnly = true;
            this.ColBorrar.Text = "Quitar";
            this.ColBorrar.UseColumnTextForButtonValue = true;
            this.ColBorrar.Width = 120;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(915, 36);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(25, 34);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(88, 16);
            this.lblNroFactura.TabIndex = 32;
            this.lblNroFactura.Text = "Factura Nº: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.gbTarjeta);
            this.groupBox2.Controls.Add(this.chkTarjeta);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.lblDni);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 234);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // dtpFechaVto
            // 
            this.dtpFechaVto.Location = new System.Drawing.Point(359, 23);
            this.dtpFechaVto.Name = "dtpFechaVto";
            this.dtpFechaVto.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVto.TabIndex = 77;
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(81, 66);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(152, 20);
            this.txtCodigoSeguridad.TabIndex = 76;
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(81, 22);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(152, 20);
            this.txtNroTarjeta.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "N° de Tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 72;
            this.label6.Text = "Código de \r\nSeguridad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Fecha de venc:";
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Location = new System.Drawing.Point(239, 105);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(108, 17);
            this.chkTarjeta.TabIndex = 70;
            this.chkTarjeta.Text = "Pago con Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            this.chkTarjeta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(399, 22);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Telefono:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(123, 22);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(152, 20);
            this.txtDni.TabIndex = 67;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(73, 24);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 66;
            this.lblDni.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(399, 63);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(152, 20);
            this.txtApellido.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "DNI";
            // 
            // txtDniFiltro
            // 
            this.txtDniFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDniFiltro.Location = new System.Drawing.Point(836, 44);
            this.txtDniFiltro.Name = "txtDniFiltro";
            this.txtDniFiltro.Size = new System.Drawing.Size(196, 20);
            this.txtDniFiltro.TabIndex = 38;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrar.Location = new System.Drawing.Point(679, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 28);
            this.btnFiltrar.TabIndex = 37;
            this.btnFiltrar.Text = "Buscar cliente";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cApellido,
            this.cDni,
            this.ColTelefono,
            this.NroTarjeta,
            this.CodigoSeguridad,
            this.FechaVenc});
            this.dgvConsultar.Location = new System.Drawing.Point(679, 73);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.RowHeadersWidth = 62;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(461, 155);
            this.dgvConsultar.TabIndex = 36;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick);
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(1028, 234);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(112, 28);
            this.btnEliminarFiltro.TabIndex = 40;
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // gbTarjeta
            // 
            this.gbTarjeta.Controls.Add(this.label6);
            this.gbTarjeta.Controls.Add(this.dtpFechaVto);
            this.gbTarjeta.Controls.Add(this.label5);
            this.gbTarjeta.Controls.Add(this.txtCodigoSeguridad);
            this.gbTarjeta.Controls.Add(this.label7);
            this.gbTarjeta.Controls.Add(this.txtNroTarjeta);
            this.gbTarjeta.Location = new System.Drawing.Point(18, 128);
            this.gbTarjeta.Name = "gbTarjeta";
            this.gbTarjeta.Size = new System.Drawing.Size(586, 100);
            this.gbTarjeta.TabIndex = 78;
            this.gbTarjeta.TabStop = false;
            this.gbTarjeta.Text = "Tarjeta";
            // 
            // cNombre
            // 
            this.cNombre.FillWeight = 160F;
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 8;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 125;
            // 
            // cApellido
            // 
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.MinimumWidth = 8;
            this.cApellido.Name = "cApellido";
            this.cApellido.ReadOnly = true;
            this.cApellido.Width = 125;
            // 
            // cDni
            // 
            this.cDni.HeaderText = "DNI";
            this.cDni.MinimumWidth = 8;
            this.cDni.Name = "cDni";
            this.cDni.ReadOnly = true;
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // NroTarjeta
            // 
            this.NroTarjeta.HeaderText = "Column1";
            this.NroTarjeta.Name = "NroTarjeta";
            this.NroTarjeta.ReadOnly = true;
            this.NroTarjeta.Visible = false;
            // 
            // CodigoSeguridad
            // 
            this.CodigoSeguridad.HeaderText = "Column1";
            this.CodigoSeguridad.Name = "CodigoSeguridad";
            this.CodigoSeguridad.ReadOnly = true;
            this.CodigoSeguridad.Visible = false;
            // 
            // FechaVenc
            // 
            this.FechaVenc.HeaderText = "Column1";
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.ReadOnly = true;
            this.FechaVenc.Visible = false;
            // 
            // FrmNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 789);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDniFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvConsultar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNuevaFactura";
            this.Text = "FrmNuevaFactura";
            this.Load += new System.EventHandler(this.FrmNuevaFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.gbTarjeta.ResumeLayout(false);
            this.gbTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboArticulos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.CheckBox cBObraSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.DateTimePicker dtpFechaVto;
        private System.Windows.Forms.TextBox txtCodigoSeguridad;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSeguridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
    }
}