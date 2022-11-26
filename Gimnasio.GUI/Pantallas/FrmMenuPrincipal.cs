using Gimnasio.GUI.Pantallas;
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
        public MenuPrincipal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

        }

        private void btnCrearSocio_Click(object sender, EventArgs e)
        {
            MenuCargaSocio menuCargaSocio = new MenuCargaSocio();
            menuCargaSocio.Show();
            this.Hide();
        }

        private void btbBuscarSocio_Click(object sender, EventArgs e)
        {
            FrmConsultaSociosYProfesores menuConsultaSocio = new FrmConsultaSociosYProfesores();
            menuConsultaSocio.Show();
            this.Hide();
        }

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {
            MenuProfesores menuProfesores = new MenuProfesores();
            menuProfesores.Show();
            this.Hide();
        }

        private void btnCrearActividad_Click(object sender, EventArgs e)
        {
            FrmActividades frmActividades= new FrmActividades();
            frmActividades.Show();
            this.Hide();
        }

        private void btnVerActividades_Click(object sender, EventArgs e)
        {
            FrmConsultaActividadesAbonos frmConsultaActividadesAbonos=new FrmConsultaActividadesAbonos();
            frmConsultaActividadesAbonos.Show();
            this.Hide();
        }
    }
}
