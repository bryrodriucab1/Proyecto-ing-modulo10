using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class Premio
    {
        [DataMember(Order = 1)]
        public string nombre_juego { get; set; }

        [DataMember(Order = 2)]
        public string hora_sorteo { get; set; }

        [DataMember(Order = 3)]
        public string item_resultado { get; set; }

        [DataMember(Order = 4)]
        public string monto_apuesta { get; set; }

        [DataMember(Order = 5)]
        public string monto_pagar { get; set; }

        [DataMember(Order = 6)]
        public string serial { get; set; }

    }
}
