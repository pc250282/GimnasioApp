using Gimnasio.Clases;
using Gimnasio.GUI.Pantallas;
using Gimnasio.Services;
using MaterialSkin;
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
    public partial class FrmAsignarSueldo : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private ProfesorAdmin profesor;
        private APIProfesorServices profesorServices = new APIProfesorServices();
        private double sueldo;
        private int horasTrabajadas;
        public FrmAsignarSueldo(ProfesorAdmin profesor)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.profesor = profesor;
            lblApellido.Text = $"Apellido: {profesor.apellido}";
            lblNombre.Text = $"Nombre: {profesor.nombre}";
            lblLegajo.Text = $"Legajo: {profesor.IdProfesor.ToString()}";

            obtenerAcvidadDelProfesor();

        }

        private void obtenerAcvidadDelProfesor()
        {
            List<ActividadAdmin> lstActividadesDelProfesor = profesorServices.getActividesDelProfesor(profesor.IdProfesor);
            calcularSueldo(lstActividadesDelProfesor);
            tablaActividadesProfesor.Rows.Clear();
            foreach (ActividadAdmin actividad in lstActividadesDelProfesor)
            {
                llenarTablaActividades(actividad);

            }
        }

        public void calcularSueldo(List<ActividadAdmin> lstActividadesDelProfesor)
        {
            int contador = lstActividadesDelProfesor.Count();
            while (contador > 0)
            {
                foreach (ActividadAdmin actividad in lstActividadesDelProfesor)
                {
                    horasTrabajadas += actividad.horasPorSemana;
                    sueldo += ((actividad.valorCuotaPura * actividad.porcentajeProfesor) / 100);
                    contador -= 1;
                }
            }


            lblSueldo.Text = $"$ {sueldo.ToString()}";
        }
        private void llenarTablaActividades(ActividadAdmin actividad)
        {
            int rowIndex = tablaActividadesProfesor.Rows.Add();


            tablaActividadesProfesor.Rows[rowIndex].Cells[0].Value = actividad.nombreActividad;
            tablaActividadesProfesor.Rows[rowIndex].Cells[1].Value = $"$ {actividad.valorCuotaPura}";
            tablaActividadesProfesor.Rows[rowIndex].Cells[2].Value = $"{actividad.nombreAbono}";
            tablaActividadesProfesor.Rows[rowIndex].Cells[3].Value = $"% {actividad.porcentajeProfesor}";
            tablaActividadesProfesor.Rows[rowIndex].Cells[4].Value = $" {actividad.horasPorSemana} hs";

        }

        private void btnConfirmarSueldo_Click(object sender, EventArgs e)
        {
            try
            {
                int result = profesorServices.asignarSueldoProfesor(profesor.IdProfesor, sueldo);
                this.Close();
                new FrmConsultaProfesores().Show();
            }
            catch (Exception error)

            {
                MaterialMessageBox.Show("Algo salió mal : " + error);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmConsultaProfesores().Show();
        }
    }
}
