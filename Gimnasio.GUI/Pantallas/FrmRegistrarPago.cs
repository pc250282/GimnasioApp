using Gimnasio.Clases;
using Gimnasio.Clases.Dto;
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
        private PagoDto pagoConfirmado;
        private DateTime fechaActual = DateTime.Now;
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
            lblAbonoNuevo.Visible = false;
            lblNuevoValor.Visible = false;
            lblNumSocio.Text = "N° de socio: " + socio.IdSocio.ToString();
            lblApellidoSocio.Text = "Apellido: " + socio.apellido.ToString();
            if (socio.nombreAbono != null)
            {
                lblAbonoSocio.Text = "Abono: " + socio.nombreAbono.ToString();
            }
            else
            {
                socio.nombreAbono = "Sin membresia";
                lblAbonoSocio.Text = "Abono: " + socio.nombreAbono.ToString();
            }
            if (socio.fk_IdEstado == 6)
            {
                lblAbonoNuevo.Text = "Registra deuda";
            }

            lblNombre.Text = "Nombre: " + socio.nombre.ToString();
            obtenerMdp();
            obtenerAbonoAcobrar();
        }

        public FrmRegistrarPago(SocioAdmin socio, int IdAbonoSocio)
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
            lblAbonoSocio.Text = $"Membresia actual:  {socio.nombreAbono.ToString()} ";
            btnRegistrarPago.Text = "ACTUALIZAR MEMBRESIA";
            lblTitulo.Text = "Valor total del abono: ";


            lblNombre.Text = "Nombre: " + socio.nombre.ToString();
            obtenerMdp();
            obtenerAbonoNuevo(IdAbonoSocio);

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

        public Pagos obtenerPagoAnterior(int IdAbonoSocio)
        {
            Pagos pagoAnterior = pagosServices.getPagoByIdSocio(IdAbonoSocio);
            return pagoAnterior;
        }

        public void obtenerAbonoNuevo(int IdAbonoSocio)
        {
            List<AbonoSocio> lstAbonos = abonosServices.getAbonosSocios();
            foreach (AbonoSocio abono in lstAbonos)
            {
                if (abono.IdAbonoSocio == IdAbonoSocio)
                {
                    lblMontoPago.Text = " $ " + abono.valor.ToString();
                    montoApagar = abono.valor;
                    fk_AbonoSocio = abono.IdAbonoSocio;
                    lblAbonoNuevo.Text = $"Membresia nueva: {abono.nombreAbono.ToString()}";
                    montoApagar = abono.valor;
                    lblNuevoValor.Text = $"Dif. a pagar: -${calculoDePago(montoApagar).ToString()} ";
                }
            }

        }

        public double calculoDePago(double valor)
        {
            Pagos pagoAnterior = obtenerPagoAnterior(socio.IdSocio);
            TimeSpan diferencia = fechaActual.Subtract(socio.fechaUltimoPago);
            int difDiasPendientes = (int)Math.Round(30 - (diferencia.TotalDays));
            int diasApagar = 30 - difDiasPendientes;
            double valorAbonoEnDias = valor / 30;
            double montoYaAbonado = pagoAnterior.montoPago;
            double valorDePago = Math.Round(valor - (diasApagar * valorAbonoEnDias) - montoYaAbonado);
            return valorDePago;
        }

        public void registrarPagoParcial()
        {
            DateTime fechaActual = DateTime.Now;

            Pagos nuevoPago = new Pagos()
            {
                fechaPago = fechaActual,
                montoPago = montoApagar,
                fk_Socio_id = socio.IdSocio,
                fk_Mdp_id = int.Parse(sltMdp.SelectedValue.ToString()),
                fk_AbonoCobrado_id = fk_AbonoSocio
            };
            int idPagoRegistrado = pagosServices.insertPago(nuevoPago);
            if (idPagoRegistrado >= 1)
            {
                int idEstado = 4; //Asinamos : Activo-cambio de abono reciente
                MaterialMessageBox.Show($"Se registro el pago del socio N° {socio.IdSocio.ToString()}, el N° de recibo es:{idPagoRegistrado} ");
                int resultado = sociosServices.editarAbonoSocio(socio.IdSocio, fk_AbonoSocio, idEstado);
            }
            else
            {
                MaterialMessageBox.Show($"Ocurrió un error registrando el pago del socio: {socio.nombre}");
            }
        }
        public void registrarPago()
        {
            DateTime fechaActual = DateTime.Now;

            try
            {
                Pagos nuevoPago = new Pagos()
                {
                    fechaPago = fechaActual,
                    montoPago = montoApagar,
                    fk_Socio_id = socio.IdSocio,
                    fk_Mdp_id = int.Parse(sltMdp.SelectedValue.ToString()),
                    fk_AbonoCobrado_id = fk_AbonoSocio
                };
                int idPagoRegistrado = pagosServices.insertPago(nuevoPago);
                if (idPagoRegistrado >= 1)
                {
                    pagoConfirmado = pagosServices.getPagoById(idPagoRegistrado);
                    MaterialMessageBox.Show($"Se registro la fecha de pago del socio N° {socio.IdSocio.ToString()}, el N° de recibo es: " + idPagoRegistrado);
                    int resultado = sociosServices.actualizarFechaPagoSocio(socio.IdSocio, fechaActual);
                    btnRegistrarPago.Visible = false;
                    sltMdp.Visible = false;
                    lblMontoPago.Visible = false;
                    txtMail.Text = $"{socio.mail}";
                    lblTitulo.Visible = false;
                    groupBox1.Visible = true;
                    txtDescripcionPago.Text = $"\n -------------------------------------\n\n" +
                        $"Cliente: {pagoConfirmado.nombre} {pagoConfirmado.apellido}\n\n" +
                        $"Fecha: {pagoConfirmado.fechaPago}\n\n" +
                        $"Medio de pago: {pagoConfirmado.nombreMdp}\n\n" +
                        $"Producto: Abono {pagoConfirmado.nombreAbono}\n\n" +
                        $"-------------------------------------\n";
                }
                else
                {
                    MaterialMessageBox.Show($"Ocurrió un error registrando el pago del socio: {socio.nombre}");
                }
            }
            catch (Exception error)
            {
                MaterialMessageBox.Show("Algo salió mal : " + error);


            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmConsultaSocios().Show();

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (btnRegistrarPago.Text == "ACTUALIZAR ABONO")
            {
                registrarPagoParcial();
            }
            else
            {
                registrarPago();
            }
            //this.Close();
            //new FrmConsultaSocios().Show();
        }

        private void btnEnvioComprobante_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show($"Comprobante enviado");
            this.Close();
            new FrmConsultaSocios().Show();
        }
    }
}
