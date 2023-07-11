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
        private APIProfesorServices profesorServices = new APIProfesorServices();
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

        }

        private void obtenerProfesores()
        {
            List<ProfesorAdmin> lstProfes = profesorServices.getProfesores();
            tablaProfesores.Rows.Clear();
            foreach (ProfesorAdmin profesor in lstProfes)
            {
                llenarTableProfesores(profesor);
                lstIdsProfesores.Add(profesor.IdProfesor.ToString());
            }
        }

        private void llenarTableProfesores(ProfesorAdmin profesor)
        {
            int rowIndex = tablaProfesores.Rows.Add();


            tablaProfesores.Rows[rowIndex].Cells[0].Value = profesor.IdProfesor;
            tablaProfesores.Rows[rowIndex].Cells[1].Value = profesor.nombreEstado;
            tablaProfesores.Rows[rowIndex].Cells[2].Value = profesor.nombre;
            tablaProfesores.Rows[rowIndex].Cells[3].Value = profesor.apellido;
            tablaProfesores.Rows[rowIndex].Cells[4].Value = profesor.fechaContratacion.ToShortDateString();
            tablaProfesores.Rows[rowIndex].Cells[5].Value = $"$ {profesor.sueldo.ToString()}";
        }


        private void llenarIds()
        {
            sltNumProfesor.DataSource = lstIdsProfesores;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btbAsignarSueldo_Click(object sender, EventArgs e)
        {
            int idProfesor = int.Parse(sltNumProfesor.SelectedValue.ToString());
            ProfesorAdmin profesor = profesorServices.getProfesorById(idProfesor);
            FrmAsignarSueldo frmAsignarSueldo = new FrmAsignarSueldo(profesor);
            this.Hide();
            frmAsignarSueldo.Show();
        }


        private void tablaProfesores_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaProfesores.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada en el DataGridView
                int idSeleccionado = (int)tablaProfesores.SelectedRows[0].Cells["idProfesor"].Value;

                // Seleccionar el valor correspondiente en el ComboBox
                sltNumProfesor.Text = idSeleccionado.ToString();
            }
        }

    }
}
