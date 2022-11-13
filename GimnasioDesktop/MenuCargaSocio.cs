using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;


namespace GimnasioDesktop
{
    public partial class MenuCargaSocio : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        //DatosMaestros datosMaestros = new DatosMaestros();
        public MenuCargaSocio()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);

            //ObtenerGeneros();
        }

        public void obtenerGeneros()
        {
            //List<Genero> lstGenero = datosMaestros.getGenero();

            //sltGenero.DisplayMember = "nombreGenero";
            //sltGenero.ValueMember = "idGenero";
            //sltGenero.DataSource = lstGenero;

        }
    }
}
