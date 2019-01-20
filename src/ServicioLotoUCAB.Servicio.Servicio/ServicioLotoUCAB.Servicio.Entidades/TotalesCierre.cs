using System;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    public class TotalesCierre
    {
        public string descripcion { get; set; }

        public int cantidad_tickets { get; set; }

        public string monto_total { get; set; }
    }
}
