using Gimnasio.Clases;
using Gimnasio.GUI.Pantallas;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gimnasio.GUI
{
    public partial class FrmConsultaSocios : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private APISocioServices securityServices = new APISocioServices();
        private List<string> lstIds = new List<string>();
        private List<string> lstApellidos = new List<string>();
        private List<string> lstIdsProfesores = new List<string>();
        private DateTime fechaActual = DateTime.Now;
        private int flagAbono;
        private int idUser;
        APILoginServices login = new APILoginServices();

        public FrmConsultaSocios()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.idUser = idUser;
            obtenerSocios();
            obtenerEstados();
            llenarIds();

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        private void obtenerSocios()
        {

            List<SocioAdmin> lstSocios = securityServices.getSocios();
            tablaSocios.Rows.Clear();
            foreach (SocioAdmin socio in lstSocios)
            {
                llenarTablaSocios(socio);
                lstIds.Add(socio.IdSocio.ToString());
                lstApellidos.Add(socio.apellido);
            }
        }



        private void llenarTablaSocios(SocioAdmin socio)
        {
            int rowIndex = tablaSocios.Rows.Add();

            tablaSocios.Rows[rowIndex].Cells[0].Value = socio.IdSocio;
            tablaSocios.Rows[rowIndex].Cells[1].Value = socio.dni;
            tablaSocios.Rows[rowIndex].Cells[2].Value = socio.nombreAbono;
            tablaSocios.Rows[rowIndex].Cells[3].Value = socio.fechaDeInscripcion.ToShortDateString();
            tablaSocios.Rows[rowIndex].Cells[4].Value = socio.nombreEstado;
            tablaSocios.Rows[rowIndex].Cells[5].Value = socio.nombre;
            tablaSocios.Rows[rowIndex].Cells[6].Value = socio.apellido;
            tablaSocios.Rows[rowIndex].Cells[7].Value = socio.telefono;
            tablaSocios.Rows[rowIndex].Cells[8].Value = socio.mail;
            tablaSocios.Rows[rowIndex].Cells[9].Value = socio.fechaUltimoPago.ToShortDateString();
            // Comparo fechas, si existe pago pendiente pinto en rojo
            if (!string.IsNullOrEmpty(socio.nombreAbono) && socio.nombreAbono.Contains("Anual"))
            {
                TimeSpan diferencia = fechaActual.Subtract(socio.fechaUltimoPago);
                if (diferencia.TotalDays <= 365)
                {
                    tablaSocios.Rows[rowIndex].Cells[9].Style.BackColor = Color.Green;
                }
                else
                {
                    tablaSocios.Rows[rowIndex].Cells[9].Style.BackColor = Color.Red;
                }
                if (tablaSocios.Rows[rowIndex].Cells[4].Value.ToString().Contains("Inactivo"))
                {
                    tablaSocios.Rows[rowIndex].Cells[4].Style.BackColor = Color.Red;
                }
            }
            else
            {
                TimeSpan diferencia = fechaActual.Subtract(socio.fechaUltimoPago);
                if (diferencia.TotalDays <= 30)
                {
                    tablaSocios.Rows[rowIndex].Cells[9].Style.BackColor = Color.Green;
                }
                else
                {
                    tablaSocios.Rows[rowIndex].Cells[9].Style.BackColor = Color.Red;
                }
            }


        }

        private void tablaSocios_SelectionChanged(object sender, EventArgs e)
        {

            if (tablaSocios.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada en el DataGridView
                int idSeleccionado = (int)tablaSocios.SelectedRows[0].Cells["idSocio"].Value;

                // Seleccionar el valor correspondiente en el ComboBox
                sltNumSocio.Text = idSeleccionado.ToString();
            }
        }

        private void llenarIds()
        {
            sltNumSocio.DataSource = lstIds;
        }


        public void obtenerEstados()
        {
            List<Estado> lstEstado = securityServices.getEstado();
            object objectToRemove = null;
            foreach (Estado estado in lstEstado)
            {
                if (estado.idEstado == 1007)
                {
                    objectToRemove = estado;

                }
            }
            if (objectToRemove != null)
            {
                lstEstado.Remove((Estado)objectToRemove);
            }

            sltEstado.DisplayMember = "nombreEstado";
            sltEstado.ValueMember = "idEstado";
            sltEstado.DataSource = lstEstado;
        }




        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {

            int idSocio = int.Parse(sltNumSocio.SelectedValue.ToString());
            SocioAdmin socio = securityServices.getSocioById(idSocio);
            flagAbono = socio.fk_IdAbonoSocio;
            TimeSpan diferencia = fechaActual.Subtract(socio.fechaUltimoPago);

            if (!string.IsNullOrEmpty(socio.nombreAbono) && socio.nombreAbono.Contains("Anual"))
            {
                bool abonoAnual = true;
                if (diferencia.TotalDays >= 365 || socio.fk_IdEstado == 3 || socio.fk_IdEstado == 5)
                {
                    FrmRegistrarPago frmRegistrarPago = new FrmRegistrarPago(socio, idUser);
                    frmRegistrarPago.Show();
                    this.Hide();
                    return;
                }
                //Requerimiento: Posibilidad de registrar pago omitiendo la validacion de dias, aplica a socios que cambiaron a un abono anual
                else if (diferencia.TotalDays <= 365 && socio.fk_IdEstado == 6)
                {
                    FrmRegistrarPago frmRegistrarPago = new FrmRegistrarPago(socio, idUser);
                    frmRegistrarPago.Show();
                    this.Hide();
                    return;
                }
                //No tiene que pagar aun, el valor obtenido es sobre la fecha actual por eso le sumo 30 dias para obtener dias que restan de abono
                else
                {
                    MaterialMessageBox.Show($"El socio seleccionado no posee deuda, le restan " + Math.Round(365 - (diferencia.TotalDays)) + " dias.");
                    return;
                }

            }

            if (diferencia.TotalDays >= 30 || socio.fk_IdEstado == 3 || socio.fk_IdEstado == 5)
            {
                if (flagAbono == 0)
                {
                    MaterialMessageBox.Show("El socio seleccionado no tiene membresia asignada");
                }

                else
                {
                    FrmRegistrarPago frmRegistrarPago = new FrmRegistrarPago(socio, idUser);
                    frmRegistrarPago.Show();
                    this.Hide();
                }
            }

            //No tiene que pagar aun, el valor obtenido es sobre la fecha actual por eso le sumo 30 dias para obtener dias que restan de abono
            else
            {
                MaterialMessageBox.Show($"El socio seleccionado no posee deuda, le restan " + Math.Round(30 - (diferencia.TotalDays)) + " dias.");
            }


        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            int idSocio = int.Parse(sltNumSocio.SelectedValue.ToString());
            SocioAdmin socio = securityServices.getSocioById(idSocio);
            flagAbono = socio.fk_IdAbonoSocio;
            if (flagAbono == 0)
            {
                FrmAsignarMembresiaSocios frmAbono = new FrmAsignarMembresiaSocios(socio, idUser);
                frmAbono.Show();
                this.Hide();
            }
            else
            {
                MaterialMessageBox.Show("El socio seleccionado ya tiene una membresia asignada");
            }

        }

        private void btnUpdateAbono_Click(object sender, EventArgs e)
        {
            int idSocio = int.Parse(sltNumSocio.SelectedValue.ToString());
            SocioAdmin socio = securityServices.getSocioById(idSocio);
            flagAbono = socio.fk_IdAbonoSocio;
            if (flagAbono == 0)
            {
                MaterialMessageBox.Show("El socio seleccionado no tiene membresia asignada");
            }

            else if (flagAbono != 0 && (!string.IsNullOrEmpty(socio.nombreAbono) && socio.nombreAbono.Contains("Anual")))
            {
                flagAbono = 0;
                MaterialMessageBox.Show("No es posible cambiar un abono Anual, el socio debe gestionar el cambio desde atencion al cliente");
            }

            else
            {
                FrmAsignarMembresiaSocios frmAbono = new FrmAsignarMembresiaSocios(socio, idUser);
                frmAbono.Show();
                this.Hide();
            }

        }

        private void btnActualizarEstado_Click_1(object sender, EventArgs e)
        {
            int idEstado = int.Parse(sltEstado.SelectedValue.ToString());
            int idSocio = int.Parse(sltNumSocio.SelectedValue.ToString());
            SocioAdmin socio = securityServices.getSocioById(idSocio);
            try
            {
                if (socio.fk_IdEstado == idEstado)
                {
                    MaterialMessageBox.Show($"El estado seleccionado es igual al actual");

                }

                else if (socio.fk_IdEstado == 1 && idEstado != 2)
                {
                    MaterialMessageBox.Show($"El socio esta Activo, solo es posible cambiarlo a Innactivo");

                }

                else if (socio.fk_IdEstado == 3 || socio.fk_IdEstado == 5 || socio.fk_IdEstado == 6 || socio.fk_IdEstado == 1007)
                {
                    if (idEstado == 5)
                    {
                        int resultado = securityServices.editarEstadoSocio(idSocio, idEstado);
                        if (resultado >= 1)
                        {
                            obtenerSocios();
                            MaterialMessageBox.Show($"Se actualizó con exito el estado del socio N° {idSocio.ToString()}");
                        }
                    }
                    else
                    {
                        MaterialMessageBox.Show($"No es posible cambiar el estado del socio, debe registrar el pago primero");
                    }

                }


                else
                {
                    int resultado = securityServices.editarEstadoSocio(idSocio, idEstado);
                    if (resultado >= 1)
                    {
                        obtenerSocios();
                        MaterialMessageBox.Show($"Se actualizó con exito el estado del socio N° {idSocio.ToString()}");
                    }

                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Ocurrió un error cambiando el estado del socio N°: {idSocio.ToString()}");
            }

        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            int idSocio = int.Parse(sltNumSocio.SelectedValue.ToString());
            SocioAdmin socio = securityServices.getSocioById(idSocio);
            MenuCargaSocio menuCargaSocio = new MenuCargaSocio(socio, idUser);
            menuCargaSocio.Show();
            this.Hide();
        }
    }
}
