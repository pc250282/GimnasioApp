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
    public partial class FrmRegistrarPago : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SocioAdmin socio;
        private APIPagosServices pagosServices = new APIPagosServices();
        private APIAbonosServices abonosServices = new APIAbonosServices();
        private APISocioServices sociosServices = new APISocioServices();
        private float montoApagar;
        private int fk_AbonoSocio;
        public FrmRegistrarPago()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
        }

        public FrmRegistrarPago(SocioAdmin socio)
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
            lblApellidoSocio.Text = "Apellido: " + socio.apellido.ToString();
            lblAbonoSocio.Text = "Abono: " + socio.nombreAbono.ToString();
            lblNombre.Text= "Nombre: " + socio.nombre.ToString();
            obtenerMdp();
            obtenerAbonoAcobrar();
  
        }

        public void obtenerMdp()
        {
            List<MedioDePago> lstMdp = pagosServices.getMediosDePago();

            sltMdp.DisplayMember = "nombreMdp";
            sltMdp.ValueMember = "idMdp";
            sltMdp.DataSource = lstMdp;

        }

        public void obtenerAbonoAcobrar()
        {
            List<AbonoSocio> lstAbonos = abonosServices.getAbonosSocios();
            foreach (AbonoSocio abono in lstAbonos)
            {
                if (abono.IdAbonoSocio == socio.fk_IdAbonoSocio)
                {
                    lblMontoPago.Text = " $ " + abono.valor.ToString();
                    montoApagar = abono.valor;
                    fk_AbonoSocio = abono.IdAbonoSocio;
                }
            }
        }

        public void registrarPago()
        {
            DateTime fechaActual = DateTime.Now;

            Pagos nuevoPago = new Pagos()
            {
                fechaPago = fechaActual,
                montoPago = montoApagar,
                fk_Socio_id = socio.IdSocio,
                fk_idMdp = int.Parse(sltMdp.SelectedValue.ToString()),
                fk_AbonoCobrado_id = fk_AbonoSocio
            };
            int idPagoRegistrado = pagosServices.insertPago(nuevoPago);
            if (idPagoRegistrado >= 1)
            {
                MaterialMessageBox.Show($"Se registro la fecha de pago del socio N° {socio.IdSocio.ToString()}, el N° de recibo es: " + idPagoRegistrado);
                int resultado = sociosServices.actualizarFechaPagoSocio(socio.IdSocio, fechaActual);
            }
            else
            {
                MaterialMessageBox.Show($"Ocurrió un error registrando el pago del socio: {socio.nombre}");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmConsultaSociosYProfesores().Show();

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            registrarPago();
        }
    }
}
