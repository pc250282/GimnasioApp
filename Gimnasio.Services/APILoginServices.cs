using Gimnasio.Clases;
using Gimnasio.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Services
{
    public class APILoginServices
    {
        DatosMaestros datosMaestros= new DatosMaestros();
        public List<Usuario> obtenerUsuarios()
        {
            return datosMaestros.ObtenerUsuarios();
        }

        public List<Roles> obtenerRoles()
        {
            return datosMaestros.ObtenerRoles();
        }
        public Usuario loginUsuarios(string txtUsuario, string txtPassword)
        {
            Usuario result = null;
            List<Usuario> usuarios = this.obtenerUsuarios();
            foreach (Usuario usuarioLogin in usuarios)
            {

                if (usuarioLogin.nombreUsuario == txtUsuario && usuarioLogin.password == txtPassword)
                {
                    result = usuarioLogin;
                    break;
                }

            }
            return result;
        }

        public Usuario getUsuarioAdminById(int idUser) 
        {
            return datosMaestros.GetUsuarioAdmin(idUser);
        }

        public Usuario getUsuarioById(int idUser)
        {
            return datosMaestros.GetUsuario(idUser);
        }
        public int insertUsuario(Usuario usuarioNuevo)
        {
            return datosMaestros.InsertUsuario(usuarioNuevo);
        }

        public int editarRolUsuario(int idUser,int idRolUsuario)
        {
            return datosMaestros.EditarRolUsuario(idUser,idRolUsuario);
        }

        public int editPassword(int idUser,string password)
        {
            return datosMaestros.EditarPasswordUsuario(idUser,password);
        }
    }
}
