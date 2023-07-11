using Gimnasio.Clases;
using Gimnasio.GUI.Validaciones;
using Gimnasio.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        APIProfesorServices profesorServices = new APIProfesorServices();
        APISocioServices personaServices = new APISocioServices();
        ValidacionesFront validacionesFrontEnd = new ValidacionesFront();
        APILoginServices loginServices = new APILoginServices();
        private int idUser;
        public MenuProfesores(int idUser)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.idUser = idUser;
            obtenerGeneros();
        }



        public void obtenerGeneros()
        {
            List<Genero> lstGenero = personaServices.getGenero();

            sltGenero.DisplayMember = "nombreGenero";
            sltGenero.ValueMember = "IdGenero";
            sltGenero.DataSource = lstGenero;
        }

        public void obtenerRoles()
        {
            List<Roles> lstRoles = loginServices.obtenerRoles();

            sltRoles.DisplayMember = "nombreRol";
            sltRoles.ValueMember = "IdRol";
            sltRoles.DataSource = lstRoles;
        }


        private bool ingresoProfesorNuevo()
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
                    mail = txtMail.Text,
                    fk_IdGenero = int.Parse(sltGenero.SelectedValue.ToString()),
                    fechaNacimiento = sltFechaNacimiento.Value != null ? sltFechaNacimiento.Value : new DateTime(2022, 28, 05),


                };
                Profesor profesorNuevo = new Profesor()
                {
                    //fk_IdEstado=int.Parse(sltEstado.SelectedValue.ToString())
                    //fk_idActividad = int.Parse(sltActividad.SelectedValue.ToString()),
                    fechaContratacion = DateTime.Now,
                    sueldo = 0.0

                };

                int idPersona = personaServices.insertPersona(nuevaPersona);
                int insertResult = profesorServices.insertProfesor(idPersona, profesorNuevo);


                MaterialMessageBox.Show("El profesor : " + profesorNuevo.nombre + " " + profesorNuevo.apellido + " se registro con exito");
                this.Close();
                new MenuPrincipal().Show();
                return true;
            }
            catch (SqlException error)
            {
                int errorCode = error.Number;
                if (errorCode == 2627)
                {
                    MaterialMessageBox.Show("Ya existe un Socio con ese DNI, porfavor validar en sistema");
                }
                else if (errorCode == 2628)
                {
                    MaterialMessageBox.Show("Error: Porfavor valida los campos ingresados");
                }
                else
                {
                    MaterialMessageBox.Show("Algo salió mal : " + error);
                }
                return false;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (validacionDeCampos())
            {
                bool exito = ingresoProfesorNuevo();
                if (exito == true)
                {
                    this.Close();
                    new MenuPrincipal(idUser).Show();
                }
            }

            else
            {
                MaterialMessageBox.Show("Debes completar todos los datos para registrar al profesor");
            };
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal(idUser).Show();

        }

        private bool validacionDeCampos()
        {
            bool resultado = false;
            if (txtNombre.Text.Trim().Length >= 1 && txtApellido.Text.Trim().Length >= 1 && txtDNI.Text.Trim().Length >= 1
                && txtTelefono.Text.Trim().Length >= 1 && txtDireccion.Text.Trim().Length >= 1)
            {
                resultado = true;
            }
            return resultado;
        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloNumeros(e);
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloLetras(e);
        }

        private void txtApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloLetras(e);
        }

        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloNumeros(e);
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloNumeros(e);
        }
    }
}
