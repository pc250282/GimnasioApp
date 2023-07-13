using Gimnasio.Clases;
using Gimnasio.GUI.Pantallas;
using Gimnasio.Services;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.GUI
{
    public partial class MenuPrincipal : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Usuario usuario;
        APILoginServices login = new APILoginServices();
        public MenuPrincipal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            timer1.Enabled = true;
        }

        public MenuPrincipal(int idUser)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            timer1.Enabled = true;

            this.usuario = login.getUsuarioById(idUser);
            toolStripStatusRol.Text = $"Rol: {usuario.nombreRol}";
            toolStripStatusUsuario.Text = $"Usuario: {usuario.nombreUsuario}";
            if (usuario.fk_IdRol == 2)
            {
                btnAdminPagos.Text = "VER PAGOS";
                btnBuscarProfesores.Visible = false;
                btnCrearActividad.Visible = false;
                btnCrearEmpleado.Visible = false;
                btnCrearProfesor.Visible = false;
                btnCambiarRol.Visible = false;
                grpGerencia.Visible = false;
                this.SetBounds(0, 0, 524, 527);
                btnLogOff.Location = new Point(40, 345);
            }


        }

        private void btnCrearSocio_Click(object sender, EventArgs e)
        {
            MenuCargaSocio menuCargaSocio = new MenuCargaSocio(usuario.idUser);
            menuCargaSocio.ShowDialog();

        }

        private void btbBuscarSocio_Click(object sender, EventArgs e)
        {
            FrmConsultaSocios menuConsultaSocio = new FrmConsultaSocios();
            menuConsultaSocio.ShowDialog();

        }

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {

            MenuProfesores menuProfesores = new MenuProfesores(usuario.idUser);
            menuProfesores.ShowDialog();

        }


        private void btnCrearActividad_Click(object sender, EventArgs e)
        {
            FrmActividades frmActividades = new FrmActividades();
            frmActividades.ShowDialog();

        }

        private void btnVerActividades_Click(object sender, EventArgs e)
        {
            FrmConsultaActividadesAbonos frmConsultaActividadesAbonos = new FrmConsultaActividadesAbonos(usuario.idUser);
            frmConsultaActividadesAbonos.ShowDialog();

        }

        private void btnBuscarProfesores_Click(object sender, EventArgs e)
        {

            FrmConsultaProfesores frmConsultaProfesores = new FrmConsultaProfesores();
            frmConsultaProfesores.ShowDialog();

        }

        private void btnAdminPagos_Click(object sender, EventArgs e)
        {
            FrmHistorialPagos frmHistorialPagos = new FrmHistorialPagos(usuario.idUser);
            frmHistorialPagos.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm");
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario menuUsuario = new FrmCrearUsuario(usuario);
            menuUsuario.ShowDialog();

        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            if (usuario.fk_IdRol == 3)
            {
                FrmCrearUsuario menuCambioPassword = new FrmCrearUsuario(usuario.idUser);
                menuCambioPassword.ShowDialog();

            }
            else
            {
                FrmCrearUsuario frmActualizaUsuario = new FrmCrearUsuario(usuario);
                frmActualizaUsuario.ShowDialog();

            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FrmMembresiasEstablecimiento frmMembresias = new FrmMembresiasEstablecimiento();
            frmMembresias.ShowDialog();
        }
    }
}
