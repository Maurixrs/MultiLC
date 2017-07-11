using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiLC.Models
{
    public class Venta
    {
        public int IdVenta { get; set; }

        public int IdUsuario { get; set; }
        public virtual Usuario usuario { get; set; }

        public string Descripcion { get; set; }

    }
}