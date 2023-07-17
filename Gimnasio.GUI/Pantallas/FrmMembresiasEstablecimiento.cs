using Gimnasio.Clases;
using Gimnasio.GUI.Validaciones;
using Gimnasio.Services;
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

namespace Gimnasio.GUI.Pantallas
{
    public partial class FrmMembresiasEstablecimiento : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        APISocioServices securityServices = new APISocioServices();
        APIAbonosServices abonosServices = new APIAbonosServices();
        ValidacionesFront validacionesFrontEnd = new ValidacionesFront();
        private SocioAdmin socioEditar;
        private int idUser;
        APILoginServices login = new APILoginServices();
        public FrmMembresiasEstablecimiento()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.idUser = idUser;
            obtenerIva();
        }

        public void obtenerIva()
        {
            List<TipoIva> lstIva = abonosServices.getTipoIva();

            //Mostrar Actividades existentes
            sltTipoIva.DisplayMember = "alicuota";
            sltTipoIva.ValueMember = "id";
            sltTipoIva.DataSource = lstIva;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcularValorFinal()
        {
            // Validación de entrada
            if (string.IsNullOrEmpty(sltTipoIva.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                return;
            }

            double iva;
            double valorSinIva;

            // Conversión de sltTipoIva.Text a double
            if (!double.TryParse(sltTipoIva.Text, out iva))
            {
                // Mostrar un mensaje de error o realizar alguna otra acción apropiada
                return;
            }

            // Conversión de txtValor.Text a double
            if (!double.TryParse(txtValor.Text, out valorSinIva))
            {
                // Mostrar un mensaje de error o realizar alguna otra acción apropiada
                return;
            }

            // Cálculos
            double valorIva = Math.Round(valorSinIva * (iva / 100));
            double valorTotal = Math.Round(valorSinIva + valorIva);
            lblIVA.Text = $"Imp: $ {valorIva.ToString()}";
            lblValorFinal.Text = $"Precio:$ {valorTotal.ToString()}";
            lblNombreMembresia.Text = txtNombreMembresia.Text.ToUpper();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                AbonoSocio nuevoAbono = new AbonoSocio
                {
                    nombreAbono = txtNombreMembresia.Text,
                    valor = float.Parse(txtValor.Text),
                    fk_tipoIva = int.Parse(sltTipoIva.SelectedValue.ToString())
                };

                int result = abonosServices.insertMembresia(nuevoAbono);
                if (result > 0)
                {
                    MaterialMessageBox.Show($"El abono {nuevoAbono.nombreAbono} para los socios se creo con exito, el ID es {result}");
                }
                else
                {
                    MaterialMessageBox.Show("No se creo el abono, algo salio mal");
                };
            }
            catch (SqlException ex)
            {
                int errorCode = ex.Number;
                if (errorCode == 2627)
                {
                    MaterialMessageBox.Show("Ya existe una membresia con ese nombre, porfavor validar en sistema");
                }
                else if (errorCode == 2628)
                {
                    MaterialMessageBox.Show("Error: Porfavor valida los campos ingresados");
                }
                else
                {
                    MaterialMessageBox.Show("Algo salió mal : " + ex);
                }

            }
        }

        private void sltTipoIva_SelectedValueChanged(object sender, EventArgs e)
        {
            calcularValorFinal();
        }

        private void txtValor_SelectionChanged(object sender, EventArgs e)
        {
            calcularValorFinal();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int idBusqueda = int.Parse(txtIdAbono.Text);
            try
            {
                //Obtengo la lista de abonos
                List<AbonoSocio> lstAbonos = new List<AbonoSocio>();
                lstAbonos = abonosServices.getAbonosSocios();
                AbonoSocio objectFound = null;
                foreach (AbonoSocio abonoAeditar in lstAbonos)
                {
                    if (abonoAeditar.IdAbonoSocio == idBusqueda)
                    {
                        objectFound = abonoAeditar;
                    }
                }
                if (objectFound != null)
                {
                    lblImp.Text = objectFound.fk_tipoIva.ToString();
                    lblNombre.Text = $" {objectFound.nombreAbono}";
                    lblValorTotal.Text = $"$ {objectFound.valor.ToString()}";
                    btnEliminar.Visible = true;
                    btnEditar.Visible = true;
                }
                else
                {
                    MaterialMessageBox.Show("No se encontro ningun abono con ID ingresado");
                }



            }
            catch (SqlException ex)
            {
                MaterialMessageBox.Show("Algo salio mal" + ex);
            }




        }

        private void txtIdAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionesFrontEnd.soloNumeros(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idBusqueda;

            // Validacion del campo de busqueda
            if (!int.TryParse(txtIdAbono.Text, out idBusqueda))
            {
                MaterialMessageBox.Show("El ID de búsqueda no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Muestro un mensaje de confirmar antes de borrar
            DialogResult result = MaterialMessageBox.Show("¿Estás seguro de que deseas eliminar la membresía?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si se presiona SI
            if (result == DialogResult.Yes)
            {
                int resultado = abonosServices.borrarMembresia(idBusqueda);
                this.Hide();
            }
        }
    }
}
