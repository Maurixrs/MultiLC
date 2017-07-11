using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiLC.Models
{
    public class Puntos
    {
        public int IdPuntos { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaPuntos { get; set; }
        public string Disponibilidad { get; set; }
    }
}