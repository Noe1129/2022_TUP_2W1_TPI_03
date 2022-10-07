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
    public partial class FrmFacturas : Form
    {
        FacturaController controladorFacturas;
        public FrmFacturas()
        {
            InitializeComponent();
            controladorFacturas = new FacturaController();
        }

        //----------------------------------------BOTONES----------------------

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            CargarGrillaFacturas();
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            CargarGrillaFacturas();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;
            Filtrar(fechaDesde,fechaHasta);
            
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nroFactura = int.Parse(dgvConsultar.CurrentRow.Cells[0].Value.ToString());

            if (dgvConsultar.CurrentCell.ColumnIndex == 5)
            {
                //boton editar abre otro form
                new FrmDetalles(nroFactura).ShowDialog();
            }
            if (dgvConsultar.CurrentCell.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    controladorFacturas.EliminarFactura(nroFactura);
                    CargarGrillaFacturas();

                }
            }
        }

        //--------------------------------------METODOS-------------------------

        private void CargarGrillaFacturas()
        {
            dgvConsultar.Rows.Clear();
            DataTable table = controladorFacturas.obtenerFacturas();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["idFactura"], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3], table.Rows[i][4]);
            }
        }

        private void Filtrar(DateTime fechaDesde,DateTime fechaHasta)
        {
            DataTable table = controladorFacturas.FacturaPorFecha(fechaDesde,fechaHasta);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["idFactura"], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3]);
            }
        }
    }
}
