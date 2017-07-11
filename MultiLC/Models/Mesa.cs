using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiLC.Models
{
    public class Mesa
    {
        public int IdMesa { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }

        public ICollection<Venta> Ventas { get; set; } 

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaCierre { get; set; }   
        
    }
}