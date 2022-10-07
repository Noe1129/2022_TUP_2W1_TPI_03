using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmatown.Controllers;
using farmatown.Modelos;

namespace farmatown.Vistas
{
    public partial class FrmNuevaFactura : Form
    {
        Usuario usuario;
        Factura factura;
        FacturaController controladorFacturas;
        ArticleController controladorArticulos;
        ClientController controladorClientes;

        public FrmNuevaFactura(Usuario usuario)
        {
            InitializeComponent();
            controladorArticulos = new ArticleController();
            controladorFacturas = new FacturaController();
            controladorClientes = new ClientController();
            this.usuario = usuario;
            factura = new Factura();
        }



        private void FrmNuevaFactura_Load(object sender, EventArgs e)
        {
            lblNroFactura.Text = "Factura Nº: " + controladorFacturas.ObtenerProximaFactura().ToString();
            CargarComboArticulos();
            CargarClientesEnGrilla();
            lblFecha.Text += DateTime.Now.ToString("dd/MMMM/yy");
            txtDescuento.Text = "0";
            gbTarjeta.Enabled = false;
        }

        //---------------------------------------BOTONES-----------------------------------------

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (validateArticulo())
            {

                //creamos un DataRowView
                //cada fila va a ser un item de mi grilla
                //lo debemos castear
                //el iten seleccionado el en combo lo voy a comvertir en una fila de la grilla
                DataRowView item = (DataRowView)cboArticulos.SelectedItem;

                //creo unas variables para almacenar los datos del articulo seleccionado
                //ID
                int prod = Convert.ToInt32(item.Row.ItemArray[0]);
                //NOMBRE ARTICULO
                string nom = item.Row.ItemArray[1].ToString();
                //TIPO ARTICULO
                int idTipoArticulo = Convert.ToInt32(item.Row.ItemArray[2]);
                string descTipoArticulo = item.Row.ItemArray[3].ToString();
                TipoArticulo tipo = new TipoArticulo(idTipoArticulo, descTipoArticulo);
                //PRECIO UNITARIO
                double pre = Convert.ToDouble(item.Row.ItemArray[4]);
                //CANTIDAD
                int cantVenta = Convert.ToInt32(nudCantidad.Text);
                //PORCENTAJE DE DESCUENTO
                int descuento = Convert.ToInt32(txtDescuento.Text);

                //STOCK DISPONIBLE DEL ARTICULO SELECCIONADO
                int stockDisponible = controladorArticulos.ObtenerStock(prod);

                //verifico el stock para poder descontarlo de la cantidad de articulos disponibles (le paso el id del producto y la cantidad que quiero vender).
                if (stockDisponible<cantVenta) //si hay stock sufieciente procedo.
                {
                    MessageBox.Show("Stock insuficiente. Hay " + stockDisponible + " " + nom + " disponibles", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else {
                    //Creo el articulo.
                    Articulo a = new Articulo(prod, pre, nom, tipo);

                    //aca ya tengo el detalle con su articulo,cantidad,porcentaje de descuento.
                    DetalleFactura detalle = new DetalleFactura(a, cantVenta, descuento);
                    //Calculo el monto descontado.
                    detalle.CalcularMontoDescontado();
                    //calculo el total de este detalle.
                    double total = detalle.CalcularSubtotal();
                    //agrego el detalle a la factura.
                    factura.AgregarDetalle(detalle);

                    //agrego el detalle a la grilla.
                    dgvDetalles.Rows.Add(new object[] { prod, nom, tipo.Descripcion, pre, cantVenta, descuento, total });

                    //calculo el total de la factura.
                    lblTotal.Text = "Total $ " + factura.CalcularTotal().ToString();
                }
               
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateCliente())
            {
                Cliente cliente = new Cliente(int.Parse(txtDni.Text), Convert.ToInt32(txtTelefono.Text), txtNombre.Text, txtApellido.Text);
                controladorClientes.CrearCliente(cliente);
                if (chkTarjeta.Checked) {
                    factura.FormaPago = 1;
                    Tarjeta tarjeta = new Tarjeta(long.Parse(txtNroTarjeta.Text), int.Parse(txtCodigoSeguridad.Text), dtpFechaVto.Value, int.Parse(txtDni.Text));
                    controladorClientes.CrearTarjeta(tarjeta);
                }
                else
                {
                    factura.FormaPago = 0;

                }
                
                GuardarFactura(factura);
            }
            

            
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 7)
            {
                factura.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                lblTotal.Text = "Total $ " + factura.CalcularTotal().ToString();
            }
        }

        //-------------------------------------------METODOS---------------------------------------------------

        //VALIDACIONES
        private bool ValidateCliente()
        {
            //valido que los campos del cliente no esten vacios
            if (txtDni.Text == string.Empty)
            {
                MessageBox.Show("Porfavor indique el dni", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Porfavor ingrese un telefono", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Porfavor llene el nombre del cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Porfavor complete el apellido del cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //valido los tipos de dato del dni y el telofono
            try
            {
                Convert.ToInt32(txtDni.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El Dni debe ser un numero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            try
            {
                Convert.ToInt32(txtTelefono.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El Telefono debe ser un numero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private bool validateArticulo()
        {
            //valido si el articulo seleccionado ya esta en la grilla.
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColArticulo"].Value.ToString().Equals(cboArticulos.Text))
                {
                    MessageBox.Show("Este producto ya se encuentra agregado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            //valido que exista una cantidad del articulo seleccionado
            if (nudCantidad.Text.Equals("0") || nudCantidad.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe elegir una cantidad", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //valido que exista un producto seleccionado
            if (cboArticulos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;


        }
        //FIN VALIDACIONES

        private void CargarClientesEnGrilla()
        {
            dgvConsultar.Rows.Clear();
            DataTable table = controladorClientes.ObtenerClientesGrillaConTarjeta();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3], table.Rows[i][4], table.Rows[i][5], table.Rows[i][6]);
            }
        }

        private void CargarClientesConFiltro()
        {
            int dni = Convert.ToInt32(txtDni.Text);
            dgvConsultar.Rows.Clear();
            DataTable table = controladorClientes.ObtenerClientesPorDni(dni);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3]);
            }
        }

        private bool ValidarCampo()
        {
            try
            {
                Convert.ToInt32(txtDni.Text);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("El campo dni debe ser un numero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void CargarComboArticulos()
        {
            DataTable tabla = controladorArticulos.obtenerArticulosComboBox();
            cboArticulos.DataSource = tabla;
            cboArticulos.ValueMember = "idArticulo";
            cboArticulos.DisplayMember = "nombre";

        }

        private void GuardarFactura(Factura factura)
        {
            factura.IdUsuario = usuario.IdUsuario;
            factura.DniCliente = Convert.ToInt32(txtDni.Text);
            factura.Total = factura.CalcularTotal();
            factura.ObraSocial = cBObraSocial.Checked;
            if (controladorFacturas.ConfirmarFactura(factura))
            {
                MessageBox.Show("La factura se grabo correctamente", "control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetDefault();
            }
            else
            {
                MessageBox.Show("La factura no se pudo grabar", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private void SetDefault()
        {
            factura.LimpiarDetalles();
            dgvDetalles.Rows.Clear();
            cBObraSocial.Checked = false;
            txtDescuento.Text = "0";
            nudCantidad.Value = 0;
            cboArticulos.SelectedIndex = 0;
            lblTotal.Text = "Total $ " + factura.CalcularTotal().ToString();
            lblNroFactura.Text = "Factura Nº: " + controladorFacturas.ObtenerProximaFactura().ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampo())
            {
                CargarClientesConFiltro();
            }
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            CargarClientesEnGrilla();
            txtDniFiltro.Text = "";
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvConsultar.CurrentRow.Cells[0].Value.ToString();
            txtApellido.Text = dgvConsultar.CurrentRow.Cells[1].Value.ToString();
            txtDni.Text = dgvConsultar.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvConsultar.CurrentRow.Cells[3].Value.ToString();
            try{
                txtNroTarjeta.Text = dgvConsultar.CurrentRow.Cells[4].Value.ToString();
                txtCodigoSeguridad.Text = dgvConsultar.CurrentRow.Cells[5].Value.ToString();
                dtpFechaVto.Value = (DateTime)dgvConsultar.CurrentRow.Cells[6].Value;
            }
            catch
            {

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTarjeta.Checked)
            {
                gbTarjeta.Enabled = true;
            }
            else
            {
                gbTarjeta.Enabled = false;
            }
        }
        
    }
}
