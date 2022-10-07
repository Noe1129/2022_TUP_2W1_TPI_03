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
    public partial class FrmModificarCliente : Form
    {
        Cliente cliente;
        ClientController controladorCliente;
        public FrmModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            controladorCliente = new ClientController();
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCliente())
            {
                cliente.Dni = Convert.ToInt32(lblDni.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                controladorCliente.ModificarCliente(cliente);
                this.Dispose();
                
            }
            
        }

        //------METODOS

        private void CargarDatos()
        {
            lblDni.Text = cliente.Dni.ToString();
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono.ToString();
        }

        private bool ValidarCliente()
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            } else if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un apellido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            try
            {
                Convert.ToInt32(txtTelefono.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("El telefono debe ser un numero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }
}
