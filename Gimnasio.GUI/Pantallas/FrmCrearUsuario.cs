using Gimnasio.Clases;
using Gimnasio.GUI.Validaciones;
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

namespace Gimnasio.GUI
{

    public partial class FrmCrearUsuario : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        APILoginServices loginServices = new APILoginServices();
        APISocioServices personaServices = new APISocioServices();
        private Usuario usuario;
        private Usuario usuarioAeditar;
        private int idUser;
        ValidacionesFront validacionesFrontEnd = new ValidacionesFront();
        public FrmCrearUsuario(Usuario usuario)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.usuario = usuario;
            obtenerTodosLosRoles();
            lblNombreUser.Visible=false;
        }

        public FrmCrearUsuario(int idUser)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange600, MaterialSkin.Primary.Orange600, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            this.idUser = idUser;
            this.Text = "Cambio de contraseña";
            this.usuarioAeditar = loginServices.getUsuarioById(idUser);
            //obtenerRoles();
            //txtUsuario.Text = usuarioAeditar.nombreUsuario.ToString();
            txtUsuario.Visible = false;
            lblNombreUser.Text = usuarioAeditar.nombreUsuario;
            txtPassword.Hint = "Nueva contraseña";
            txtPassword2.Password = false;
            //txtPassword2.Hint = "";
            txtPassword2.ReadOnly = true;
            //txtPassword2.Text = $"Rol actual: {usuarioAeditar.nombreRol}";
            sltRoles.Visible = false;
            btnConfirmar.Text = "CAMBIAR PASSWORD";
        }


        public void obtenerTodosLosRoles()
        {
            List<Roles> lstRoles = loginServices.obtenerRoles();
            sltRoles.DisplayMember = "nombreRol";
            sltRoles.ValueMember = "IdRol";
            sltRoles.DataSource = lstRoles;
        }
        public void obtenerRoles()
        {
            List<Roles> lstRoles = loginServices.obtenerRoles();
            object objectToRemove = null;
            foreach (Roles rolActual in lstRoles)
            {
                if (rolActual.IdRol == usuarioAeditar.fk_IdRol)
                {
                    objectToRemove = rolActual;

                }
            }
            if (objectToRemove != null)
            {
                lstRoles.Remove((Roles)objectToRemove);
            }


            sltRoles.DisplayMember = "nombreRol";
            sltRoles.ValueMember = "IdRol";
            sltRoles.DataSource = lstRoles;

        }

        private bool ingresoEmpleadoNuevo()
        {
            try
            {
                Usuario usuarioNuevo = new Usuario()
                {
                    fk_IdRol = int.Parse(sltRoles.SelectedValue.ToString()),
                    nombreUsuario = txtUsuario.Text,
                    password = txtPassword.Text,
                };
                if (txtPassword.Text.Equals(txtPassword2.Text))
                {
                    int insertResult = loginServices.insertUsuario(usuarioNuevo);
                    MaterialMessageBox.Show("El usuario se registro con exito");
                    return true;
                }
                else
                {
                    MaterialMessageBox.Show("Error al validar contraseña, reintente");
                    return false;
                }



            }
            catch (SqlException error)
            {
                int errorCode = error.Number;
                if (errorCode == 2627)
                {
                    MaterialMessageBox.Show("El nombre de usuario ya existe, elije otro");
                }
                else if (errorCode == 2628)
                {
                    MaterialMessageBox.Show("Error: Porfavor valida los campos ingresados");
                }
                else
                {
                    MaterialMessageBox.Show("Algo salió mal : " + error);
                }
                return false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnConfirmar.Text == "CAMBIAR PASSWORD")
                {
                    string password = txtPassword.Text;
                    int result = loginServices.editPassword(usuarioAeditar.idUser, password);
                    if (result > 0)
                    {
                        MaterialMessageBox.Show("Contraseña actualizada");
                        this.Close();

                    }
                }
                else
                {
                    bool exito = ingresoEmpleadoNuevo();
                    if (exito == true)
                    {
                        this.Hide();
                    }
                }
            }
            catch (SqlException ex)
            {
                MaterialMessageBox.Show("Algo salió mal : " + ex);
            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

