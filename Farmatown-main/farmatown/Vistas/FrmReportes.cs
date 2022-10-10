using farmatown.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmatown.Vistas
{
    public partial class FrmReportes : Form
    {
        ReportesController controladorReportes;
        public FrmReportes()
        {
            InitializeComponent();
            controladorReportes = new ReportesController();
            CargarReporte2();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataVista.facturasObraSocial' Puede moverla o quitarla según sea necesario.
            this.facturasObraSocialTableAdapter.Fill(this.dataVista.facturasObraSocial);
            // TODO: esta línea de código carga datos en la tabla 'dataVista.clientes_frecuentes' Puede moverla o quitarla según sea necesario.
            //this.clientes_frecuentesTableAdapter.Fill(this.dataVista.clientes_frecuentes);
            // TODO: esta línea de código carga datos en la tabla 'dataVista.articulosVendidos' Puede moverla o quitarla según sea necesario.
            //this.articulosVendidosTableAdapter.Fill(this.dataVista.articulosVendidos);



            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CargarReporte2()
        {
            dgvClientes.Rows.Clear();
            DataTable tabla = controladorReportes.obtenerReporte2();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvClientes.Rows.Add(tabla.Rows[i]["Nombre"], tabla.Rows[i][1]);
            }
        }

        private void CargarReporte1()
        {
            int mes = cboMes.SelectedIndex + 1;
            if(mes == 0)
            {
                MessageBox.Show("Debe seleccionar un mes", "Sistema");
                return;
            }
            dgvArticulos.Rows.Clear();
            DataTable tabla = controladorReportes.obtenerReporte1(mes);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvArticulos.Rows.Add(tabla.Rows[i]["Articulo"], tabla.Rows[i][1], tabla.Rows[i][2], tabla.Rows[i][3]);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CargarReporte1();
        }
    }
}

