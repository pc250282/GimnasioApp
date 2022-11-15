using Gimnasio.Clases;
using Gimnasio.DataStore;
using Gimnasio.Services;
using MaterialSkin.Controls;
using static System.Windows.Forms.AxHost;

namespace Gimnasio.GUI
{
    public partial class MenuCargaSocio : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        SecurityServices securityServices = new SecurityServices();
        public MenuCargaSocio()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            obtenerEstados();
            obtenerGeneros();
         
        }

        public void obtenerGeneros()
        {
            List<Genero> lstGenero = securityServices.getGenero();

            sltGenero.DisplayMember = "nombreGenero";
            sltGenero.ValueMember = "IdGenero";
            sltGenero.DataSource = lstGenero;
        }
        public void obtenerEstados()
        {
            List<Estado> lstEstado = securityServices.getEstado();
            
            sltEstado.DisplayMember = "nombreEstado";
            sltEstado.ValueMember = "idEstado";
            sltEstado.DataSource = lstEstado;
        }

        private void ingresoSocioNuevo()
        {
            try
            {
                Persona nuevaPersona = new Persona()
                {
                    nombre=txtNombre.Text,
                    apellido=txtApellido.Text,
                    dni=txtDNI.Text,
                    telefono=txtTelefono.Text,
                    direccion=txtDireccion.Text,
                    fk_IdGenero=int.Parse(sltGenero.SelectedValue.ToString()),
                    fechaNacimiento=sltFechaNacimiento.Value!=null? sltFechaNacimiento.Value: new DateTime(2022,28,05),


                };
                Socio socio = new Socio()
                {
                    //fk_IdEstado=int.Parse(sltEstado.SelectedValue.ToString())
                };

                int idPersona = securityServices.insertPersona(nuevaPersona);
                int insertResult = securityServices.insertSocio(idPersona);


            }
            catch (Exception error)
            {
                MaterialMessageBox.Show("Algo salió mal : " + error);


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

        private void btnConfirmaAlta_Click(object sender, EventArgs e)
        {
            if (checkPago.Checked) {
                ingresoSocioNuevo();
                    }
            else {
                MaterialMessageBox.Show("Debe registrar el pago del socio");
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
    }
}
