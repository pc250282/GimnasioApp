﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class ProfesorAdmin
    {
        public int IdProfesor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string nombreEstado { get; set; }
        public List<int> idActividad {  get; set; }
        public DateTime fechaContratacion { get; set; }
        public double sueldo { get; set; }
  

    }
}
