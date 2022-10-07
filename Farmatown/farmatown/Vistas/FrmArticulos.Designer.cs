
namespace farmatown.Vistas
{
    partial class FrmArticulos
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoArticulo = new System.Windows.Forms.ComboBox();
            this.btnCrearArticulo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdTipoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "ARTICULOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.btnEliminarFiltro);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.dgvConsultar);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 395);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Articulo";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(76, 26);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(196, 20);
            this.txtProducto.TabIndex = 48;
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Location = new System.Drawing.Point(918, 309);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarFiltro.TabIndex = 47;
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click_1);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(294, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 31);
            this.btnFiltrar.TabIndex = 46;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColProd,
            this.cIdTipoArticulo,
            this.ColTipoArt,
            this.ColPrecio,
            this.ColStock,
            this.ColModificar});
            this.dgvConsultar.Location = new System.Drawing.Point(21, 63);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.RowHeadersWidth = 62;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(1009, 219);
            this.dgvConsultar.TabIndex = 45;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtStockInicial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboTipoArticulo);
            this.groupBox2.Controls.Add(this.btnCrearArticulo);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(730, 476);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 258);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo articulo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(137, 76);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio por unidad: ";
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(137, 147);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(121, 20);
            this.txtStockInicial.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock inicial: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de articulo: ";
            // 
            // cboTipoArticulo
            // 
            this.cboTipoArticulo.FormattingEnabled = true;
            this.cboTipoArticulo.Location = new System.Drawing.Point(137, 110);
            this.cboTipoArticulo.Name = "cboTipoArticulo";
            this.cboTipoArticulo.Size = new System.Drawing.Size(121, 21);
            this.cboTipoArticulo.TabIndex = 3;
            // 
            // btnCrearArticulo
            // 
            this.btnCrearArticulo.Location = new System.Drawing.Point(112, 197);
            this.btnCrearArticulo.Name = "btnCrearArticulo";
            this.btnCrearArticulo.Size = new System.Drawing.Size(100, 34);
            this.btnCrearArticulo.TabIndex = 2;
            this.btnCrearArticulo.Text = "Crear articulo";
            this.btnCrearArticulo.UseVisualStyleBackColor = true;
            this.btnCrearArticulo.Click += new System.EventHandler(this.btnCrearArticulo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre: ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 150;
            // 
            // ColProd
            // 
            this.ColProd.HeaderText = "Articulo";
            this.ColProd.MinimumWidth = 8;
            this.ColProd.Name = "ColProd";
            this.ColProd.ReadOnly = true;
            this.ColProd.Width = 350;
            // 
            // cIdTipoArticulo
            // 
            this.cIdTipoArticulo.HeaderText = "IdTipoArticulo";
            this.cIdTipoArticulo.Name = "cIdTipoArticulo";
            this.cIdTipoArticulo.ReadOnly = true;
            this.cIdTipoArticulo.Visible = false;
            // 
            // ColTipoArt
            // 
            this.ColTipoArt.HeaderText = "Tipo de articulo";
            this.ColTipoArt.Name = "ColTipoArt";
            this.ColTipoArt.ReadOnly = true;
            this.ColTipoArt.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 8;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 105;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock disponible";
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            this.ColStock.Width = 150;
            // 
            // ColModificar
            // 
            this.ColModificar.HeaderText = "Modificar";
            this.ColModificar.Name = "ColModificar";
            this.ColModificar.ReadOnly = true;
            this.ColModificar.Text = "Modificar";
            this.ColModificar.UseColumnTextForButtonValue = true;
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 793);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(504, 154);
            this.Name = "FrmArticulos";
            this.Text = "FrmArticulos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoArticulo;
        private System.Windows.Forms.Button btnCrearArticulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdTipoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewButtonColumn ColModificar;
    }
}