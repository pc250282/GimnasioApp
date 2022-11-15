using Gimnasio.Clases;
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

namespace Gimnasio.GUI
{
    public partial class FrmConsultaSociosYProfesores : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SecurityServices securityServices = new SecurityServices();
        private List<string> lstIds = new List<string>();
        private List<string> lstIdsProfesores = new List<string>();
        public FrmConsultaSociosYProfesores()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

            obtenerSocios();
            obtenerProfesores();
            obtenerEstados();
            llenarIds();
            obtenerActividades();
            obtenerAbono();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuPrincipal().Show();
        }

        private void obtenerSocios()
        {
            List<SocioAdmin> lstSocios = securityServices.getSocios();
            tablaSocios.Rows.Clear();
            foreach (SocioAdmin socio in lstSocios)
            {
                llenarTablaSocios(socio);
                lstIds.Add(socio.idSocio.ToString());
            }
        }

        private void obtenerProfesores()
        {
            List<ProfesorAdmin>lstProfes=securityServices.getProfesores();
            tablaProfesores.Rows.Clear();
            foreach (ProfesorAdmin profesor in lstProfes)
            {
                llenarTableProfesores(profesor);
                lstIdsProfesores.Add(profesor.idProfesor.ToString());
            }
        }

        private void llenarTablaSocios(SocioAdmin socio)
        {
            int rowIndex = tablaSocios.Rows.Add();

            tablaSocios.Rows[rowIndex].Cells[0].Value = socio.idSocio;
            tablaSocios.Rows[rowIndex].Cells[1].Value = socio.fechaDeInscripcion.ToShortDateString();
            tablaSocios.Rows[rowIndex].Cells[2].Value = socio.nombreEstado;
            tablaSocios.Rows[rowIndex].Cells[3].Value = socio.nombre;
            tablaSocios.Rows[rowIndex].Cells[4].Value = socio.apellido;
            tablaSocios.Rows[rowIndex].Cells[5].Value = socio.telefono;
            tablaSocios.Rows[rowIndex].Cells[6].Value = socio.fechaUltimoPago.ToShortDateString();
            if (socio.fechaUltimoPago <= DateTime.Now) {
                tablaSocios.Rows[rowIndex].Cells[6].Style.BackColor = Color.Green;
            }
            else
            {
                tablaSocios.Rows[rowIndex].Cells[6].Style.BackColor = Color.Red;
            }
            
        }


        private void llenarTableProfesores(ProfesorAdmin profesor)
        {
            int rowIndex = tablaProfesores.Rows.Add();


            tablaProfesores.Rows[rowIndex].Cells[0].Value = profesor.idProfesor;
            tablaProfesores.Rows[rowIndex].Cells[1].Value = profesor.nombre;
            tablaProfesores.Rows[rowIndex].Cells[2].Value = profesor.apellido;
            tablaProfesores.Rows[rowIndex].Cells[3].Value = profesor.fechaContratacion.ToShortDateString();
            tablaProfesores.Rows[rowIndex].Cells[4].Value = profesor.nombreActividad;
            tablaProfesores.Rows[rowIndex].Cells[5].Value = profesor.nombreEstado;
            tablaProfesores.Rows[rowIndex].Cells[6].Value = ((profesor.valorCuotaPura*profesor.porcentajeProfesor)/100).ToString();
        }
        private void llenarIds()
        {
            sltNumSocio.DataSource = lstIds;
            sltNumProfesor.DataSource = lstIdsProfesores;
        }

        public void obtenerEstados()
        {
            List<Estado> lstEstado = securityServices.getEstado();

            sltEstado.DisplayMember = "nombreEstado";
            sltEstado.ValueMember = "idEstado";
            sltEstado.DataSource = lstEstado;
        }

        public void obtenerActividades()
        {
            List<Actividad> lstActividad = securityServices.getActividad();
            
            sltActividades.DisplayMember = "nombreActividad";
            sltActividades.ValueMember = "idActividad";
            sltActividades.DataSource = lstActividad;

        }
        public void obtenerAbono()
        {
            List<Abono> lstAbono = securityServices.getAbono();
            List<Actividad> lstActividad = securityServices.getActividad();
            
            sltAbono.DisplayMember = "nombreAbono";
            sltAbono.ValueMember = "idAbono";
            sltAbono.DataSource = lstAbono;
            double sueldo = 0.0;
            
            foreach(Abono abo in lstAbono)
            {
                txtSueldo.Text = ((abo.valorCuotaPura * abo.porcentajeProfesor)/100).ToString();
            }

        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            int idEstado = int.Parse(sltEstado.SelectedValue.ToString());
            int idSocio = int.Parse(sltNumSocio.SelectedValue.ToString());

            int resultado = securityServices.editarEstadoSocio(idSocio, idEstado);
            if (resultado >= 1)
            {
                obtenerSocios();
                MaterialMessageBox.Show($"Se actualizó con exito el estado del socio N° {idSocio.ToString()}");
            }
            else
            {
                MaterialMessageBox.Show($"Ocurrió un error cambiando el estado del socio N°: {idSocio.ToString()}");
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {

            int idSocio = int.Parse(sltNumSocio.SelectedValue.ToString());
            DateTime fechaActual = DateTime.Now;

            int resultado = securityServices.actualizarFechaPagoSocio(idSocio, fechaActual);
               if (resultado >= 1)
                {
                    obtenerSocios();
                    MaterialMessageBox.Show($"Se registro la fecha de pago del socio N° {idSocio.ToString()}");
                }
                else
                {
                    MaterialMessageBox.Show($"Ocurrió un error registrando la fecha de pago del socio N°: {idSocio.ToString()}");
                }
            
        }

        private void btbAsignarActividad_Click(object sender, EventArgs e)
        {
            int fk_idActividad = int.Parse(sltActividades.SelectedValue.ToString());
            int idProfesor = int.Parse(sltNumProfesor.SelectedValue.ToString());
            double sueldo = 0.0;
            

            int resultado = securityServices.editarActividadProfesor(idProfesor, fk_idActividad,sueldo);
            if (resultado >= 1)
            {
                obtenerProfesores();
                MaterialMessageBox.Show($"Se actualizó con exito la actividad del profesor  N° {idProfesor.ToString()}");
            }
            else
            {
                MaterialMessageBox.Show($"Ocurrió un error asignando la actividad del profesor N°: {idProfesor.ToString()}");
            }
        }
    }
}
