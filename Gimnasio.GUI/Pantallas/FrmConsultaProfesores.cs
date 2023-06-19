using Gimnasio.Clases;
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
    public partial class FrmConsultaProfesores : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private APISocioServices securityServices = new APISocioServices();
        private List<string> lstIdsProfesores = new List<string>();
        private DateTime fechaActual = DateTime.Now;
        public FrmConsultaProfesores()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            InitializeComponent();
            obtenerProfesores();
            llenarIds();
            obtenerActividades();
        }

        private void obtenerProfesores()
        {
            List<ProfesorAdmin> lstProfes = securityServices.getProfesores();
            tablaProfesores.Rows.Clear();
            foreach (ProfesorAdmin profesor in lstProfes)
            {
                llenarTableProfesores(profesor);
                lstIdsProfesores.Add(profesor.idProfesor.ToString());
            }
        }

        private void llenarTableProfesores(ProfesorAdmin profesor)
        {
            int rowIndex = tablaProfesores.Rows.Add();


            tablaProfesores.Rows[rowIndex].Cells[0].Value = profesor.idProfesor;
            tablaProfesores.Rows[rowIndex].Cells[1].Value = profesor.nombreEstado;
            tablaProfesores.Rows[rowIndex].Cells[2].Value = profesor.nombre;
            tablaProfesores.Rows[rowIndex].Cells[3].Value = profesor.apellido;
            tablaProfesores.Rows[rowIndex].Cells[4].Value = profesor.nombreActividad;
            tablaProfesores.Rows[rowIndex].Cells[5].Value = profesor.fechaContratacion.ToShortDateString();
            tablaProfesores.Rows[rowIndex].Cells[6].Value = ((profesor.valorCuotaPura * profesor.porcentajeProfesor) / 100).ToString();
        }

        public void obtenerActividades()
        {
            List<Actividad> lstActividad = securityServices.getActividad();

            sltActividades.DisplayMember = "nombreActividad";
            sltActividades.ValueMember = "idActividad";
            sltActividades.DataSource = lstActividad;

        }

        private void llenarIds()
        {
            sltNumProfesor.DataSource = lstIdsProfesores;
        }
        private void btbAsignarActividad_Click(object sender, EventArgs e)
        {
            int fk_idActividad = int.Parse(sltActividades.SelectedValue.ToString());
            int idProfesor = int.Parse(sltNumProfesor.SelectedValue.ToString());
            double sueldo = 0.0;


            int resultado = securityServices.editarActividadProfesor(idProfesor, fk_idActividad, sueldo);
            if (resultado >= 1)
            {
                obtenerProfesores();
                MaterialMessageBox.Show($"Se actualizó con exito la actividad del profesor  N° {idProfesor.ToString()}");
            }
            else
            {
                MaterialMessageBox.Show($"Ocurrió un error asignando la actividad del profesor N°: {idProfesor.ToString()}");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal().Show();
        }
    }
}
