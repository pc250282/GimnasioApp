using Gimnasio.Clases;
using Gimnasio.Services;
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
    public partial class FrmCrearAbono : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        APISocioServices securityServices = new APISocioServices();
        public FrmCrearAbono()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            abonoNuevo();
        }

        private void abonoNuevo()
        {
            try
            {
                Abono nuevoAbono = new Abono()
                {
                    nombreAbono = txtNombreAbono.Text,
                    valorCuotaPura = double.Parse(txtValorAbono.Text.ToString()),
                    porcentajeEstablecimiento =double.Parse(txtPorcentajeEstablecimiento.Text.ToString()),
                    porcentajeProfesor = double.Parse(txtPorcentajeProfesor.Text.ToString()),
                };

                int idAbono = securityServices.insertAbono(nuevoAbono);
                if (idAbono >= 1)
                {
                    MaterialMessageBox.Show($"Se registro el abono " + nuevoAbono.nombreAbono + " con exito");
                }
                else
                {
                    MaterialMessageBox.Show($"Ocurrió un error registrando el abono");
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
            new FrmActividades().Show();
        }

        private void mostrarValores()
        {
            int valor = int.Parse(txtValorAbono.Text.ToString());
            int porcentajeProfe=int.Parse(txtPorcentajeProfesor.Text.ToString());
            int porcentajeEstablecimiento=int.Parse(txtPorcentajeEstablecimiento.Text.ToString());
            lblMuestraGanancia.Text="$ "+ ((porcentajeEstablecimiento*valor)/100).ToString();
            lblMuestraPorcentajeProfesor.Text= "$ " + ((porcentajeProfe * valor) / 100).ToString();

        }

        private void lblMuestraGanancia_MouseClick(object sender, MouseEventArgs e)
        {
            mostrarValores();
        }

        private void lblMuestraPorcentajeProfesor_Click(object sender, EventArgs e)
        {
            mostrarValores();
        }
    }

  
     
}
