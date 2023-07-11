using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class Usuario
    {
        public int idUser { get; set; }
        public string nombreUsuario {  get; set; }
        public string password { get; set; }
        public int fk_IdRol { get; set; }
        public int fk_PersonaId { get; set; }
        public string nombreRol { get;set; }

    }
}
