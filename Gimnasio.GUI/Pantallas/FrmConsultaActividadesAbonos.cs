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
        private APIActividadServices actividadesServices = new APIActividadServices();
        private List<string> lstIdsActividades = new List<string>();
        public FrmConsultaActividadesAbonos()
        {

            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            obtenerActividades();
            llenarIds();
        }

        private void obtenerActividades()
        {
            List<ActividadAdmin> lstActividad = actividadesServices.getActividadesActivas();
            tablaActividades.Rows.Clear();
            foreach (ActividadAdmin actividadAdmin in lstActividad)
            {
                llenarTableActividades(actividadAdmin);
                lstIdsActividades.Add(actividadAdmin.IdActividad.ToString());
            }
        }

        private void llenarTableActividades(ActividadAdmin actividad)
        {
            int rowIndex = tablaActividades.Rows.Add();
            tablaActividades.Rows[rowIndex].Cells[0].Value = actividad.IdActividad;
            tablaActividades.Rows[rowIndex].Cells[1].Value = actividad.nombreActividad;
            tablaActividades.Rows[rowIndex].Cells[2].Value = actividad.cupo;
            tablaActividades.Rows[rowIndex].Cells[3].Value = actividad.horario;
            tablaActividades.Rows[rowIndex].Cells[4].Value = actividad.nombre;
            tablaActividades.Rows[rowIndex].Cells[5].Value = actividad.nombreAbono;
            tablaActividades.Rows[rowIndex].Cells[6].Value = $"$ {actividad.valorCuotaPura} ";
        }

        private void llenarIds()
        {
            sltIdActividad.DataSource = lstIdsActividades;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal().Show();
        }

        private void btnEditActividad_Click(object sender, EventArgs e)
        {
            int IdActividad = int.Parse(sltIdActividad.SelectedValue.ToString());
            ActividadAdmin actividadAeditar = actividadesServices.getActividadById(IdActividad);
            if (actividadAeditar == null)
            {
                MaterialMessageBox.Show($"No se encontro la actividad seleccionada");
            }
            else
            {
                FrmActividades frmActividades = new FrmActividades(actividadAeditar);
                frmActividades.Show();
                this.Hide();


            }

        }
    }
}
