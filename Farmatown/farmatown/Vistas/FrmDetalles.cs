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

namespace farmatown.Vistas
{
    public partial class FrmDetalles : Form
    {
        FacturaController controladorFacturas;
        int nroFactura;
        public FrmDetalles(int nroFactura)
        {
            InitializeComponent();
            controladorFacturas = new FacturaController();
            this.nroFactura = nroFactura;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            lblNroFactura.Text = "Detalles de la factura numero: " + nroFactura;
            CargarDetalles();
        }

        private void CargarDetalles()
        {
            dgvDetalles.Rows.Clear();
            DataTable table = controladorFacturas.obtenerDetallesPorIdFactura(nroFactura);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvDetalles.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3], table.Rows[i][4], table.Rows[i][5]);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                                       
                if (dgvDetalles.CurrentCell.ColumnIndex == 6)
            {
                int idDetalle = int.Parse(dgvDetalles.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    controladorFacturas.EliminarDetalle(idDetalle);
                    CargarDetalles();

                }
            }
        }
    }
}
