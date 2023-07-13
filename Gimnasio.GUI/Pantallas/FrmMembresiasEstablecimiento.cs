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
                if (result >0)
                {
                    MaterialMessageBox.Show($"El abono {nuevoAbono.nombreAbono} para los socios se creo con exito");
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
    }
}
