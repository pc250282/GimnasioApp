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

namespace Gimnasio.GUI.Pantallas
{
    public partial class FrmLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private APILoginServices loginServices = new APILoginServices();
        public FrmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = true;
            grpBievenido.Visible = false;

            lblMessage.Text = "Ingreso Administrativo";
            lblMessage.Font = new Font("Arial", 20, FontStyle.Bold);
            lblMessage.ForeColor = Color.White;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.BackColor = Color.FromArgb(255, 96, 0);
            lblMessage.Size = new Size(300, 50);


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = false;
            grpBievenido.Visible = true;
        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = true;
            grpBievenido.Visible = false;
            lblMessage.Text = "Ingreso Gerencial";
            lblMessage.Font = new Font("Arial", 20, FontStyle.Bold);
            lblMessage.ForeColor = Color.White;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.BackColor = Color.FromArgb(255, 96, 0);
            lblMessage.Size = new Size(300, 50);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Usuario usuarioLogin = loginServices.loginUsuarios(txtUsuario.Text, txtPassword.Text);

            try
            {
                if (usuarioLogin != null)
                {
                    //Gerencia
                    if (usuarioLogin.fk_IdRol == 3)
                    {
                        MenuPrincipal menuPrincipal = new MenuPrincipal(usuarioLogin.idUser);
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    //Administrador
                    else if (usuarioLogin.fk_IdRol == 2)
                    {
                        MenuPrincipal menuPrincipal = new MenuPrincipal(usuarioLogin.idUser);
                        menuPrincipal.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MaterialMessageBox.Show("Revisa los datos ingresados");
                }

            }
            catch (SqlException error)
            {
                MaterialMessageBox.Show("Algo salió mal : " + error);
            }
        }
    }
}
