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
        private APIActividadServices actividadServices = new APIActividadServices();
        private APIProfesorServices profesorServices = new APIProfesorServices();
        private ActividadAdmin actividadAeditar;
        public FrmActividades()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            lblAbonoActual.Visible = false;
            lblProfesorActual.Visible = false;
            lblValorActual.Visible = false;
            lblDatos.Visible = false;
            obtenerAbonos();
            obtenerProfesoresDisponibles();
        }

        public FrmActividades(ActividadAdmin actividadAeditar)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.actividadAeditar = actividadAeditar;
            btnCreaActividad.Text = "ACTUALIZAR DATOS";
            txtHorario.Text = actividadAeditar.horario;
            txtHorasPorSemana.Text = actividadAeditar.horasPorSemana.ToString();
            txtNombreActividad.Text = actividadAeditar.nombreActividad;
            txtCupo.Text = actividadAeditar.cupoDisponible.ToString();
            obtenerAbonos();
            obtenerProfesoresDisponibles();
            if (actividadAeditar.fk_Profesor_id == 0)
            {
                lblAbonoActual.Visible = false;
                lblValorActual.Visible = false;
                lblDatos.Visible = false;
                lblProfesorActual.Visible = false;
                btnCreaActividad.Text = "ASIGNAR PROFESOR";
                txtCupo.ReadOnly = true;
                txtHorasPorSemana.ReadOnly = true;
                txtNombreActividad.ReadOnly = true;
                txtHorario.ReadOnly = true;

            }
            lblAbonoActual.Text = $"Abono: {actividadAeditar.nombreAbono}";
            if (actividadAeditar.nombre == null)
            {
                lblProfesorActual.Text = "Sin asignar";
            }
            else
            {
                lblProfesorActual.Text = $"Profesor: {actividadAeditar.nombre}";
            }

            lblValorActual.Text = $"Valor: ${actividadAeditar.valorCuotaPura}";
        }

        private void obtenerAbonos()
        {
            List<Abono> lstAbono = actividadServices.getAbono();

            //Mostrar Actividades existentes
            seleccionAbono.DisplayMember = "nombreAbono";
            seleccionAbono.ValueMember = "idAbono";
            seleccionAbono.DataSource = lstAbono;

            //Mostrar abono de la actividad seleccionada
            sltAbono.DisplayMember = "valorCuotaPura";
            sltAbono.ValueMember = "idAbono";
            sltAbono.DataSource = lstAbono;


        }

        private void obtenerProfesoresDisponibles()
        {
            List<ProfesorAdmin> lstProfesores = profesorServices.getProfesores();

            sltProfesor.DisplayMember = "apellido";
            sltProfesor.ValueMember = "idProfesor";
            sltProfesor.DataSource = lstProfesores;
        }


        private void crearActividad()
        {
            int fk_Profesor_id = 0;
            try
            {
                Actividad nuevaActividad = new Actividad()
                {
                    nombreActividad = txtNombreActividad.Text,
                    horario = txtHorario.Text,
                    horasPorSemana = int.Parse(txtHorasPorSemana.Text),
                    fk_Abono_id = int.Parse(seleccionAbono.SelectedValue.ToString()),
                    cupoDisponible = int.Parse(txtCupo.Text),


                };

                if (chkProfesor.Checked)
                {
                    nuevaActividad.fk_Profesor_id = int.Parse(sltProfesor.SelectedValue.ToString());
                }

                int insertResult = actividadServices.insertActividad(nuevaActividad);
                if (insertResult >= 1)
                {

                    MaterialMessageBox.Show($"Se registro la actividad " + nuevaActividad.nombreActividad + " con exito");
                    this.Close();
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

        private void editarActividad()
        {
            try
            {
                Actividad actividadEditada = new Actividad()
                {
                    idActividad = actividadAeditar.IdActividad,
                    nombreActividad = txtNombreActividad.Text,
                    horario = txtHorario.Text,
                    cupoDisponible = int.Parse(txtCupo.Text),
                    horasPorSemana = int.Parse(txtHorasPorSemana.Text),
                    fk_Abono_id = int.Parse(seleccionAbono.SelectedValue.ToString()),
                    fk_Profesor_id = int.Parse(sltProfesor.SelectedValue.ToString())

                };

                int insertResult = actividadServices.editarActividad(actividadEditada);

                if (insertResult >= 1)
                {

                    int updateProfesorResult = profesorServices.editarEstadoProfesor(actividadEditada.fk_Profesor_id);
                    MaterialMessageBox.Show($"Se actualizo la actividad N° {actividadEditada.idActividad}, {actividadEditada.nombreActividad} con exito");
                    this.Close();

                }
                else
                {
                    MaterialMessageBox.Show($"Ocurrió un error actualizando la actividad");
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
        }


        private void btnCreaActividad_Click(object sender, EventArgs e)
        {
            if (btnCreaActividad.Text == "ACTUALIZAR DATOS")
            {
                editarActividad();
            }
            else
            {
                crearActividad();
            }

        }

        private void txtCrearAbono_Click(object sender, EventArgs e)
        {
            FrmCrearAbono frmCrearAbono = new FrmCrearAbono();
            frmCrearAbono.Show();
            this.Hide();
        }
    }
}
