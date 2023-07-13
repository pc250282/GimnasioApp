using Gimnasio.Clases;
using Gimnasio.GUI;
using Gimnasio.Services;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.Logging;
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
    public partial class FrmConsultaActividadesAbonos : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private APIActividadServices actividadesServices = new APIActividadServices();
        private List<string> lstIdsActividades = new List<string>();
        private int idUser;
        private Usuario usuario;
        APILoginServices login = new APILoginServices();
        public FrmConsultaActividadesAbonos(int idUser)
        {

            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.idUser = idUser;
            this.usuario = login.getUsuarioById(idUser);
            if (usuario.fk_IdRol == 2)
            {
                btnCrearAbono.Visible = false;
                btnEditActividad.Visible = false;
                btnCrearAbono.Visible = false;
                materialButton2.Visible=false;
                
            }
            obtenerActividades();
            llenarIds();
        }



        private void obtenerActividades()
        {
            List<ActividadAdmin> lstActividad = actividadesServices.getActividadesActivas();
            tablaActividades.Rows.Clear();
            foreach (ActividadAdmin actividadAdmin in lstActividad)
            {
                llenarTableActividades(actividadAdmin);
                lstIdsActividades.Add(actividadAdmin.IdActividad.ToString());
            }
        }

        private void llenarTableActividades(ActividadAdmin actividad)
        {
            int rowIndex = tablaActividades.Rows.Add();
            tablaActividades.Rows[rowIndex].Cells[0].Value = actividad.IdActividad;
            tablaActividades.Rows[rowIndex].Cells[1].Value = actividad.nombreActividad;
            tablaActividades.Rows[rowIndex].Cells[2].Value = actividad.cupoDisponible;
            tablaActividades.Rows[rowIndex].Cells[3].Value = actividad.horario;
            tablaActividades.Rows[rowIndex].Cells[4].Value = actividad.nombre;
            tablaActividades.Rows[rowIndex].Cells[5].Value = actividad.nombreAbono;
            tablaActividades.Rows[rowIndex].Cells[6].Value = $"$ {actividad.valorCuotaPura} ";
            tablaActividades.Rows[rowIndex].Cells[7].Value = $" {actividad.horasPorSemana}hs ";
        }

        private void llenarIds()
        {
            sltIdActividad.DataSource = lstIdsActividades;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditActividad_Click(object sender, EventArgs e)
        {
            int IdActividad = int.Parse(sltIdActividad.SelectedValue.ToString());
            ActividadAdmin actividadAeditar = actividadesServices.getActividadById(IdActividad);
            if (actividadAeditar == null)
            {
                MaterialMessageBox.Show($"No se encontro la actividad seleccionada");
            }
            else
            {
                FrmActividades frmActividades = new FrmActividades(actividadAeditar);
                frmActividades.Show();
                this.Hide();


            }

        }

        private void tablaActividades_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaActividades.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada en el DataGridView
                int idSeleccionado = (int)tablaActividades.SelectedRows[0].Cells["IdActividad"].Value;

                // Seleccionar el valor correspondiente en el ComboBox
                sltIdActividad.Text = idSeleccionado.ToString();
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int IdActividad = int.Parse(sltIdActividad.SelectedValue.ToString());
                ActividadAdmin actividadAeditar = actividadesServices.getActividadById(IdActividad);
                FrmActividades frmActividades = new FrmActividades(actividadAeditar);
                frmActividades.Show();
                this.Hide();
            }
            catch (SqlException er)
            {
                MaterialMessageBox.Show($"No se encontro la actividad seleccionada{er}");
            }

        }

        private void btnCrearAbono_Click(object sender, EventArgs e)
        {
            FrmCrearAbono frmCrearAbono = new FrmCrearAbono();
            frmCrearAbono.Show();
            this.Hide();
        }
    }
}
