using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmatown.Controllers;
using farmatown.Modelos;

namespace farmatown.Vistas
{
    public partial class FrmModificarArticulo : Form
    {
        ArticleController controladorArticulos;
        Articulo articulo;
        public FrmModificarArticulo(Articulo articulo)
        {
            InitializeComponent();
            controladorArticulos = new ArticleController();
            this.articulo = articulo;
        }

        private void FrmModificarArticulo_Load(object sender, EventArgs e)
        {
            CargarComboTiposArticulo();
            CargarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarArticulo())
            {
                articulo.nomArticulo = txtNombre.Text;
                articulo.preUnitario= Convert.ToDouble(txtPrecio.Text);
                articulo.Stock =Convert.ToInt32(txtStock.Text);
                articulo.tipoArticulo.IdTipoArticulo = Convert.ToInt32(cboTipoArticulo.SelectedValue);
                Modificar();
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarComboTiposArticulo()
        {
            DataTable tabla = controladorArticulos.obtenerTiposArticulosComboBox();

            cboTipoArticulo.DataSource = tabla;
            cboTipoArticulo.ValueMember = "idTipoArticulo";
            cboTipoArticulo.DisplayMember = "descripcion";
        }

        private bool ValidarArticulo()
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtStock.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la cantidad de stock", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el precio del articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            try
            {
                Convert.ToDouble(txtPrecio.Text);
                Convert.ToInt32(txtStock.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("El precio y el stock deben ser numeros", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void Modificar()
        {
            if (controladorArticulos.ModificarArticulo(articulo))
            {
                MessageBox.Show("Articulo modificado con exito", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Error al modificar", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CargarCampos()
        {
            txtNombre.Text = articulo.nomArticulo;
            txtStock.Text = articulo.Stock.ToString();
            txtPrecio.Text = articulo.preUnitario.ToString();
            cboTipoArticulo.SelectedValue = articulo.tipoArticulo.IdTipoArticulo;
        }
    }
}
