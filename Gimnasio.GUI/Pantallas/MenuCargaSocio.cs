using Gimnasio.Clases;
using Gimnasio.DataStore;
using Gimnasio.GUI.Validaciones;
using Gimnasio.Services;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Net;
using static System.Windows.Forms.AxHost;

namespace Gimnasio.GUI
{
    public partial class MenuCargaSocio : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        APISocioServices securityServices = new APISocioServices();
        APIAbonosServices abonosServices = new APIAbonosServices();
        ValidacionesFront validacionesFrontEnd = new ValidacionesFront();
        private SocioAdmin socioEditar;
        public MenuCargaSocio()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            obtenerAbonos();
            obtenerGeneros();

        }

        public MenuCargaSocio(SocioAdmin socioEditar)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.socioEditar = socioEditar;
            obtenerAbonos();
            obtenerGeneros();
            txtNombre.Text = socioEditar.nombre;
            txtApellido.Text=socioEditar.apellido;
            txtDNI.Text = socioEditar.dni.ToString();
            txtTelefono.Text=socioEditar.telefono;
            txtDireccion.Text = socioEditar.direccion;
            txtMail.Text = socioEditar.mail;
            btnConfirmaAlta.Text = "ACTUALIZAR DATOS";
            checkPago.Visible = false;
            sltAbono.Visible = false;
            sltGenero.Text = socioEditar.nombreGenero;
            DateTime fechaNacimiento = new DateTime();
            fechaNacimiento = socioEditar.fechaNacimiento;
            sltFechaNacimiento.Value = fechaNacimiento;

            

        }

        public void obtenerGeneros()
        {
            List<Genero> lstGenero = securityServices.getGenero();

            sltGenero.DisplayMember = "nombreGenero";
            sltGenero.ValueMember = "IdGenero";
            sltGenero.DataSource = lstGenero;
        }
        public void obtenerAbonos()
        {
            List<AbonoSocio> lstAbonosDisponibles = abonosServices.getAbonosSocios();

            sltAbono.DisplayMember = "nombreAbono";
            sltAbono.ValueMember = "idAbonoSocio";
            sltAbono.DataSource = lstAbonosDisponibles;
        }

        private bool ingresoSocioNuevo()
        {
            int fk_IdAbonoSocio = 0;
            int insertResult = 0;
            try
            {
                Persona nuevaPersona = new Persona()
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = txtDNI.Text,
                    telefono = txtTelefono.Text,
                    direccion = txtDireccion.Text.ToLower(),
                    fk_IdGenero = int.Parse(sltGenero.SelectedValue.ToString()),
                    fechaNacimiento = sltFechaNacimiento.Value != null ? sltFechaNacimiento.Value : new DateTime(2022, 28, 05),
                    
                    
                    mail = txtMail.Text.ToLower()

                };

                if (checkPago.Checked)
                {
                    fk_IdAbonoSocio = int.Parse(sltAbono.SelectedValue.ToString());
                }


                int idPersona = securityServices.insertPersona(nuevaPersona);

                if (fk_IdAbonoSocio != 0)
                {
                    insertResult = securityServices.insertSocioConAbono(idPersona, fk_IdAbonoSocio);

                    if (insertResult >= 1)
                    {
                        MaterialMessageBox.Show($"Se registro al socio " + nuevaPersona.nombre + " con exito, y se le asigno el abono");
                    }
                }
                else if (fk_IdAbonoSocio == 0)
                {
                    insertResult = securityServices.insertSocioSinAbono(idPersona);

                    if (insertResult >= 1)
                    {
                        MaterialMessageBox.Show($"Se registro al socio " + nuevaPersona.nombre + " con exito, recuerde asignar el abono");
                    }
                }

                else
                {
                    MaterialMessageBox.Show($"Ocurrió un error registrando al socio");
                }

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

        private bool actualizaSocio()
        {
            
            int insertResult = 0;
            try
            {
                Persona personaExistente = new Persona()
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = txtDNI.Text,
                    telefono = txtTelefono.Text,
                    direccion = txtDireccion.Text.ToLower(),
                    fk_IdGenero = int.Parse(sltGenero.SelectedValue.ToString()),
                    fechaNacimiento = sltFechaNacimiento.Value != null ? sltFechaNacimiento.Value : new DateTime(2022, 28, 05),
                    mail = txtMail.Text.ToLower(),
                    idPersona = socioEditar.idPersona                  

                };

                insertResult = securityServices.editarDatosPersona(personaExistente);

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


        private void CalcularEdad(DateTime fechaNacimiento)
        {

            int edad;
            DateTime fechaActual = DateTime.Now;

            if (fechaActual.Month <= fechaNacimiento.Month)
            {
                if (fechaActual.Day <= fechaNacimiento.Day)
                {
                    edad = (fechaActual.Year - fechaNacimiento.Year);
                }
                else
                {
                    edad = (fechaActual.Year - fechaNacimiento.Year) - 1;
                }
            }
            else
            {
                edad = (fechaActual.Year - fechaNacimiento.Year);
            }

            txtEdad.Text = edad.ToString();
        }

        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMail.Text.Contains("@"))
            {
                if (txtMail.Text.Contains(".com"))
                {

                    txtMail.HelperText = "Email válido";
                }
            }
            else
            {
                txtMail.HelperText = "Debe ingresar un email válido";
            }
        }

        private void btnConfirmaAlta_Click(object sender, EventArgs e)
        {
            if (socioEditar != null)
            {
                bool exito=actualizaSocio();
                if (exito == true)
                {
                    this.Close();
                    new FrmConsultaSocios().Show();
                }
                else
                {
                    MaterialMessageBox.Show("No se actualizo al socio");
                }
            }
            
            else if (validacionDeCampos())
            {
                bool exito = ingresoSocioNuevo();
                if (exito == true)
                {
                    this.Close();
                    new MenuPrincipal().Show();
                }

            }
            else
            {
                MaterialMessageBox.Show("Debe registrar todos los datos del socio para registrarlo");
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal().Show();
        }

        private void sltFechaNacimiento_MouseEnter_1(object sender, EventArgs e)
        {
            CalcularEdad(sltFechaNacimiento.Value);
        }

        private bool validacionDeCampos()
        {
            bool resultado = false;
            if (txtNombre.Text.Trim().Length >= 1 && txtApellido.Text.Trim().Length >= 1 && txtDNI.Text.Trim().Length >= 1
                && txtTelefono.Text.Trim().Length >= 1 && txtDireccion.Text.Trim().Length >= 1 && txtMail.Text.Trim().Length >= 3)
            {
                resultado = true;
            }
            return resultado;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloLetras(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloNumeros(e);
        }
    }
}
