using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiLC.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string email { get; set; }

        public int dni { get; set; }

        public int IdMesa { get; set; }

    }
}