using Gimnasio.Clases;
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
    public partial class MenuProfesores : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        SecurityServices securityServices=new SecurityServices();

        public MenuProfesores()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            obtenerActividades();
            obtenerGeneros();
        }

        public void obtenerGeneros()
        {
            List<Genero> lstGenero = securityServices.getGenero();

            sltGenero.DisplayMember = "nombreGenero";
            sltGenero.ValueMember = "IdGenero";
            sltGenero.DataSource = lstGenero;
        }

        public void obtenerActividades()
        {
            List<Actividad> lstActividad = securityServices.getActividad();
            sltActividad.DisplayMember = "nombreActividad";
            sltActividad.ValueMember = "IdActividad";
            sltActividad.DataSource = lstActividad;
        }

        private void ingresoProfesorNuevo()
        {
            try
            {
                Persona nuevaPersona = new Persona()
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = txtDNI.Text,
                    telefono = txtTelefono.Text,
                    direccion = txtDireccion.Text,
                    fk_IdGenero = int.Parse(sltGenero.SelectedValue.ToString()),
                    fechaNacimiento = sltFechaNacimiento.Value != null ? sltFechaNacimiento.Value : new DateTime(2022, 28, 05),


                };
                Profesor profesorNuevo = new Profesor()
                {
                    //fk_IdEstado=int.Parse(sltEstado.SelectedValue.ToString())
                    fk_idActividad = int.Parse(sltActividad.SelectedValue.ToString()),
                    fechaContratacion=DateTime.Now,
                    sueldo=0.0

                };

                int idPersona = securityServices.insertPersona(nuevaPersona);
                int insertResult = securityServices.insertProfesor(idPersona, profesorNuevo);
                
                
                MaterialMessageBox.Show("El profesor : " + profesorNuevo.nombre + " " + profesorNuevo.apellido+ " se registro con exito");

            }
            catch (Exception error)
            {
                MaterialMessageBox.Show("Algo salió mal : " + error);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (validacionDeCampos())
                ingresoProfesorNuevo();
            else
            {
                MaterialMessageBox.Show("Debes completar todos los datos para registrar al profesor");
            };
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal().Show();

        }

        private bool validacionDeCampos()
        {
            bool resultado = false;
            if (txtNombre.Text.Trim().Length>=1 && txtApellido.Text.Trim().Length>=1 && txtDNI.Text.Trim().Length>=1 
                && txtTelefono.Text.Trim().Length>=1 && txtDireccion.Text.Trim().Length >= 1)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
