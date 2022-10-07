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
    public partial class FrmClientes : Form
    {
        ClientController controladorClientes;
        public FrmClientes()
        {
            InitializeComponent();
            controladorClientes = new ClientController();
        }

        //BOTONES
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrilla();
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
            txtDni.Text = "";
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultar.CurrentCell.ColumnIndex == 4) //modificar
            {
                int dni = int.Parse(dgvConsultar.CurrentRow.Cells[2].Value.ToString());
                int telefono = int.Parse(dgvConsultar.CurrentRow.Cells[3].Value.ToString());
                string nombre = dgvConsultar.CurrentRow.Cells[0].Value.ToString();
                string apellido = dgvConsultar.CurrentRow.Cells[1].Value.ToString();
                Cliente cliente = new Cliente(dni,telefono,nombre,apellido);
                new FrmModificarCliente(cliente).ShowDialog();
                CargarClientesEnGrilla();
            } 
        }

        //METODOS
        private void CargarClientesEnGrilla()
        {
            dgvConsultar.Rows.Clear();
            DataTable table = controladorClientes.ObtenerClientesGrilla();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3]);
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

        //VALIDACIONES
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
    }
}
