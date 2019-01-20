using System;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class BalanceTotal
    {
        [DataMember(Order = 1)]
        public string descripcion { get; set; }

        [DataMember(Order = 2)]
        public string monto_total { get; set; }

        [DataMember(Order = 3)]
        public int cantidad_tickets { get; set; }
    }
}
