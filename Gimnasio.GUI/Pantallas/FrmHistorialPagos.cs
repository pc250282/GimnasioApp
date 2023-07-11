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
    public partial class FrmHistorialPagos : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        APIPagosServices pagoServices = new APIPagosServices();
        private List<string> lstIds = new List<string>();
        private int idUser;

        public FrmHistorialPagos(int idUser)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            obtenerPagos();
            llenarIds();
            this.idUser = idUser;
        }

        private void obtenerPagos()
        {
            List<PagoDto> lstPagos = pagoServices.getPagos();
            tablaPagos.Rows.Clear();
            foreach (PagoDto pago in lstPagos)
            {
                llenarTablaPagos(pago);
                lstIds.Add(pago.IdPago.ToString());
            }
        }

        private void llenarTablaPagos(PagoDto pago)
        {
            int rowIndex = tablaPagos.Rows.Add();

            tablaPagos.Rows[rowIndex].Cells[0].Value = pago.IdPago;
            tablaPagos.Rows[rowIndex].Cells[1].Value = pago.fechaPago.ToShortDateString();
            tablaPagos.Rows[rowIndex].Cells[2].Value = pago.dni;
            tablaPagos.Rows[rowIndex].Cells[3].Value = pago.apellido;
            tablaPagos.Rows[rowIndex].Cells[4].Value = pago.nombre;
            tablaPagos.Rows[rowIndex].Cells[5].Value = pago.nombreAbono;
            tablaPagos.Rows[rowIndex].Cells[6].Value = pago.nombreMdp;
            tablaPagos.Rows[rowIndex].Cells[7].Value = $"$ {pago.montoPago}";

        }

        private void llenarIds()
        {
            sltPagos.DataSource = lstIds;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Close();
            new MenuPrincipal(idUser).Show();
        }

        private void tablaPagos_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaPagos.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada en el DataGridView
                int idSeleccionado = (int)tablaPagos.SelectedRows[0].Cells["idPago"].Value;

                // Seleccionar el valor correspondiente en el ComboBox
                sltPagos.Text = idSeleccionado.ToString();
            }
        }
    }
}
