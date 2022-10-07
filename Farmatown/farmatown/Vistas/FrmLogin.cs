using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmatown.Controllers;
using farmatown.Modelos;
using farmatown.Vistas;

namespace farmatown
{
    public partial class FrmLogin : Form
    {
        private readonly UserController Controlador;

        public FrmLogin(UserController controlador)
        {
            InitializeComponent();
            this.Controlador = controlador;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        //METODOS
        private void login()
        {
            string nombreUsuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            
            if (Controlador.VerificarUsuario(nombreUsuario,contrasenia))
            {
                Usuario usuario = Controlador.obtenerUsuario(nombreUsuario,contrasenia);
                FrmPrincipal nuevo = new FrmPrincipal(usuario); //pasar el usuario
                nuevo.ShowDialog();
                txtContrasenia.Text = "";
            } else {
                txtContrasenia.Text = "";
                MessageBox.Show("Usuario o contraseña incorrecta", "Sistema");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
