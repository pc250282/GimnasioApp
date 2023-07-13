using Gimnasio.Clases;
using Gimnasio.Services;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
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
                    porcentajeEstablecimiento = double.Parse(txtPorcentajeEstablecimiento.Text.ToString()),
                    porcentajeProfesor = double.Parse(txtPorcentajeProfesor.Text.ToString()),
                };

                int idAbono = securityServices.insertAbono(nuevoAbono);
                if (idAbono >= 1)
                {
                    MaterialMessageBox.Show($"Se registro el abono " + nuevoAbono.nombreAbono + " con exito");
                    this.Close();
                    new FrmActividades().Show();
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
            double valor = 0.0;
            int porcentajeProfe = 0;
            int porcentajeEstablecimiento = 0;
            valor = double.Parse(txtValorAbono.Text);
            porcentajeEstablecimiento = int.Parse(txtPorcentajeEstablecimiento.Text);
            porcentajeProfe = 100 - porcentajeEstablecimiento;
            lblMuestraGanancia.Text = "Ganancia: $ " + ((porcentajeEstablecimiento * valor) / 100).ToString();
            lblMuestraPorcentajeProfesor.Text = "A pagar al profesor: $ " + ((porcentajeProfe * valor) / 100).ToString();
            txtPorcentajeProfesor.Text = (100 - (int.Parse(txtPorcentajeEstablecimiento.Text))).ToString();
        }

        private void txtPorcentajeEstablecimiento_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPorcentajeEstablecimiento.Text))
                txtPorcentajeEstablecimiento.Text = "0";
            else
            {
                int value;
                if (!int.TryParse(txtPorcentajeEstablecimiento.Text, out value))
                    txtPorcentajeEstablecimiento.Text = "0";
                else if (value > 100 || value < 0)
                    txtPorcentajeEstablecimiento.Text = "100";
            }
            txtPorcentajeProfesor.Text = (100 - (int.Parse(txtPorcentajeEstablecimiento.Text))).ToString();
        }


        private void txtPorcentajeEstablecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            mostrarValores();
        }
    }



}
