using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmatown.Modelos;

namespace farmatown.Vistas
{
    public partial class FrmPrincipal : Form
    {
        Usuario usuario;
        public FrmPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            CustomDesign();
            confirmarPermisos();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Bienvenido " + usuario.NomUsuario + " " + usuario.ApeUsuario;
        }

        //-------------------------------------------BOTONES------------------------------------------------------

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuFacturas);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton 
            HideSubMenu();
            OpenForm(new FrmNuevaFactura(usuario));
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmFacturas());
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuTransacciones);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmArticulos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmClientes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuAcercaDe);
        }

        private void btnVerReporte_Click_1(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmReportes());
        }


        private void btnInformacion_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmInformacion());
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuArchivo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            this.Dispose();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuUsuarios);
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmNuevoUsuario());
        }

        private void btnAcercaDe_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuAcercaDe);
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuReportes);
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuLotes);
        }

        private void btnNuevoLote_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmNuevoLote());
        }

        private void btnVerLotes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new FrmLotes());
        }

        // ----------------------------------------------METODOS DE DISEÑO FORM---------------------------------
        private void CustomDesign()
        {
            subMenuFacturas.Visible = false;
            subMenuTransacciones.Visible = false;
            subMenuAcercaDe.Visible = false;
            subMenuArchivo.Visible = false;
            subMenuReportes.Visible = false;
            subMenuUsuarios.Visible = false;
            subMenuLotes.Visible = false;
        }

        private void HideSubMenu()
        {
            if (subMenuFacturas.Visible)
                subMenuFacturas.Visible = false;
            if (subMenuTransacciones.Visible)
                subMenuTransacciones.Visible = false;
            if (subMenuAcercaDe.Visible)
                subMenuAcercaDe.Visible = false;
            if (subMenuArchivo.Visible)
                subMenuArchivo.Visible = false;
            if (subMenuReportes.Visible)
                subMenuReportes.Visible = false;
            if (subMenuUsuarios.Visible)
                subMenuUsuarios.Visible = false;
            if (subMenuLotes.Visible)
                subMenuLotes.Visible = false;


        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void OpenForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            //asignamos que el form hijo no esta a nivel supérior
            childForm.TopLevel = false;
            //quitamos los bordes
            childForm.FormBorderStyle = FormBorderStyle.None;
            //le ponemos el dock para que rellene todo el panel 
            childForm.Dock = DockStyle.Fill;
            //agregamos el form a la lista de controles del panel contenedor
            PanelContainer.Controls.Add(childForm);
            //asociamos el form con el panel contenedor
            PanelContainer.Tag = childForm;
            //traemos el form al frente para tapar el logo 
            childForm.BringToFront();
            childForm.Show();
        }

        //--------------------------------------------------OTROS----------------------------------------------------

        private void confirmarPermisos()
        {
            switch (usuario.TipoUsuario)
            {
                case 2:
                    btnReportes.Enabled = false;
                    subMenuReportes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    subMenuUsuarios.Enabled = false;
                    break;
                case 3:
                    btnUsuarios.Enabled = false;
                    subMenuUsuarios.Enabled = false;
                    break;
            }

        }

    }
}
