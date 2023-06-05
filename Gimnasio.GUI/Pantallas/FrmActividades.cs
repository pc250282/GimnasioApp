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
    public partial class FrmActividades : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private APISocioServices securityServices = new APISocioServices();
        public FrmActividades()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            obtenerAbonos();

        }

        private void obtenerAbonos()
        {
            List<Abono> lstAbono = securityServices.getAbono();

            //Mostrar Actividades existentes
            seleccionAbono.DisplayMember = "nombreAbono";
            seleccionAbono.ValueMember = "idAbono";
            seleccionAbono.DataSource = lstAbono;

            //Mostrar abono de la actividad seleccionada
            sltAbono.DisplayMember = "valorCuotaPura";
            sltAbono.ValueMember = "idAbono";
            sltAbono.DataSource = lstAbono;


        }


        private void crearActividad()
        {
            try
            {
                Actividad nuevaActividad = new Actividad()
                {
                    nombreActividad = txtNombreActividad.Text,
                    horario = txtHorario.Text,
                    cupo = int.Parse(txtCupo.Text),
                    fk_idAbono = int.Parse(seleccionAbono.SelectedValue.ToString())

                };

                int insertResult = securityServices.insertActividad(nuevaActividad);
                if (insertResult >= 1)
                {
                    MaterialMessageBox.Show($"Se registro la actividad " + nuevaActividad.nombreActividad + " con exito");
                }
                else
                {
                    MaterialMessageBox.Show($"Ocurrió un error registrando la actividad");
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
            new MenuPrincipal().Show();
        }

        private void txtCrearAbono_Click(object sender, EventArgs e)
        {
            FrmCrearAbono frmCrearAbono = new FrmCrearAbono();
            frmCrearAbono.Show();
            this.Hide();
        }

        private void btnCreaActividad_Click(object sender, EventArgs e)
        {
            crearActividad();
        }
    }
}
