using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class ReporteVentas
    {
        [DataMember(Order = 1)]
        public string nombre_juego { get; set; }

        [DataMember(Order = 2)]
        public string nombre_sorteo { get; set; }

        [DataMember(Order = 3)]
        public string nombre_item { get; set; }

        [DataMember(Order = 4)]
        public string cantidad_vendida { get; set; }

        [DataMember(Order = 5)]
        public string monto_vendido { get; set; }
    }
}


            
