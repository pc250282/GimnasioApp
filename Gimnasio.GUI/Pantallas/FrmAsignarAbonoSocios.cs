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

namespace Gimnasio.GUI.Pantallas
{
    public partial class FrmAsignarAbonoSocios : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SocioAdmin socio;
        private APIAbonosServices abonosServices = new APIAbonosServices();
        private APISocioServices sociosServices = new APISocioServices();
        private DateTime fechaActual = DateTime.Now;
        private int difDiasPendientes;
        public FrmAsignarAbonoSocios()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            InitializeComponent();
        }

        public FrmAsignarAbonoSocios(SocioAdmin socio)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.socio = socio;
            lblNumSocio.Text = "N° de socio: " + socio.IdSocio.ToString();
            lblApellido.Text = "Apellido: " + socio.apellido.ToString();
            lblNombre.Text = "Nombre: " + socio.nombre.ToString();
            lblEstado.Text = "Estado: " + socio.nombreEstado.ToString();
            if (socio.nombreAbono != null)
            {
                lblAbonoActual.Text = "Abono actual: " + socio.nombreAbono.ToString();
                TimeSpan diferencia = fechaActual.Subtract(socio.fechaUltimoPago);
                difDiasPendientes = (int)Math.Round(30 - (diferencia.TotalDays));
                if (difDiasPendientes < 0)
                {
                    difDiasPendientes = 0;
                }
                lblDiasDeAbonoPendiente.Text = $"Dias restantes con abono: {difDiasPendientes.ToString()}";
            }
            else
            {
                lblAbonoActual.Text = "Abono actual: SIN ABONO ";
            }


            obtenerAbonos();
        }

        public void obtenerAbonos()
        {
            List<AbonoSocio> lstAbonosDisponibles = abonosServices.getAbonosSocios();
            //BORRAR EL ABONO ACTUAL DEL LISTADO, PORQUE LA OPCION "CAMBIAR ABONO"
            //NO TIENE QUE TENER EL ABONO ACTUAL DEL SOCIO
            object objectToRemove = null;
            foreach (AbonoSocio abonoActual in lstAbonosDisponibles)
            {
                if (abonoActual.IdAbonoSocio == socio.fk_IdAbonoSocio)
                {
                    objectToRemove = abonoActual;

                }
            }
            if (objectToRemove != null)
            {
                lstAbonosDisponibles.Remove((AbonoSocio)objectToRemove);
            }
            sltAbono.DisplayMember = "nombreAbono";
            sltAbono.ValueMember = "IdAbonoSocio";
            sltAbono.DataSource = lstAbonosDisponibles;

            //Mostrar valor del abono seleccionado
            sltValorAbono.DisplayMember = "valor";
            sltValorAbono.ValueMember = "IdAbonoSocio";
            sltValorAbono.DataSource = lstAbonosDisponibles;

        }



        public void asignarAbono()
        {
            int idAbonoSocio = int.Parse(sltAbono.SelectedValue.ToString());
            int idSocio = socio.IdSocio;
            int idEstado = 6;
            int abonoActualizado = sociosServices.editarAbonoSocio(idSocio, idAbonoSocio, idEstado);
            if (abonoActualizado >= 1)
            {
                MaterialMessageBox.Show($"Se le asigno el abono {socio.nombreAbono} al socio {socio.nombre}, debe registrar el pago");
            }
            else
            {
                MaterialMessageBox.Show($"Ocurrio un error, no se le asigno el abono al socio: {socio.nombre}");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal().Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //Actualizar abono, de socios con abono activos y
            //socios inactivos que van a cambiar el abono
            if (socio.nombreAbono != null && difDiasPendientes!=0)
            {
                int idAbonoEnviado = int.Parse(sltAbono.SelectedValue.ToString());
                FrmRegistrarPago frmRegistrarPago = new FrmRegistrarPago(socio, idAbonoEnviado);
                frmRegistrarPago.Show();
                this.Hide();

            }

            //Asignar abono a socios nuevos que no lo registraron previamente
            else
            {
                asignarAbono();
            }

        }
    }
}
