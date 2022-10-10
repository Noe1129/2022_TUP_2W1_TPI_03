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
    
    public partial class FrmNuevoUsuario : Form
    {
        Usuario usuario;
        UserController controladorUsuarios;
        public FrmNuevoUsuario()
        {
            InitializeComponent();
            controladorUsuarios = new UserController();
            usuario = new Usuario();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario())
            {
                usuario.NomUsuario = txtNombre.Text;
                usuario.ApeUsuario = txtApellido.Text;
                usuario.User = txtUsuario.Text;
                usuario.Password = txtContraseña.Text;
                usuario.TipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);
                controladorUsuarios.CrearUsuario(usuario);
                CargarUsuariosEnGrilla();

            }
            
        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarUsuariosEnGrilla();
        }

  

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultar.CurrentCell.ColumnIndex == 4)
            {
                int idUsuario = int.Parse(dgvConsultar.CurrentRow.Cells[0].Value.ToString());
                controladorUsuarios.EliminarUsuario(idUsuario);
                CargarUsuariosEnGrilla();
            }
        }

        //-----------------------METODOS

        private void CargarCombo()
        {
            DataTable tabla = controladorUsuarios.obtenerTiposUsuarioComboBox();
            cboTipoUsuario.DataSource = tabla;
            cboTipoUsuario.ValueMember = "idTipoUsuario";
            cboTipoUsuario.DisplayMember = "descripcion";
        }

        private void CargarUsuariosEnGrilla()
        {
            dgvConsultar.Rows.Clear();
            dgvConsultar.Rows.Clear();
            DataTable table = controladorUsuarios.ObtenerUsuariosGrilla();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3]);
            }
        }

        private bool ValidarUsuario()
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } 
            else if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Ingrese apellido", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Ingrese contrasña", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
