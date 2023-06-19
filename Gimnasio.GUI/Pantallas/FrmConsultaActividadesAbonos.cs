using Gimnasio.Clases;
using Gimnasio.GUI;
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

namespace Gimnasio.GUI.Pantallas
{
    public partial class FrmConsultaActividadesAbonos : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private APISocioServices securityServices = new APISocioServices();
        public FrmConsultaActividadesAbonos()
        {

            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            InitializeComponent();

            obtenerActividades();
        }

        private void llenarTableActividades(ActividadAdmin actividad)
        {
            int rowIndex = tablaActividades.Rows.Add();


            tablaActividades.Rows[rowIndex].Cells[0].Value = actividad.nombreActividad;
            tablaActividades.Rows[rowIndex].Cells[1].Value = actividad.horario;
            tablaActividades.Rows[rowIndex].Cells[2].Value = actividad.nombreProfesor;
            tablaActividades.Rows[rowIndex].Cells[3].Value = actividad.valorActividad;
            tablaActividades.Rows[rowIndex].Cells[4].Value = actividad.cupoDisponible;
        }

        private void obtenerActividades()
        {
            List<ActividadAdmin> lstActividad = securityServices.getActividadesActivas();
            tablaActividades.Rows.Clear();
            foreach (ActividadAdmin actividadAdmin in lstActividad)
            {
                llenarTableActividades(actividadAdmin);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal().Show();
        }
    }
}
