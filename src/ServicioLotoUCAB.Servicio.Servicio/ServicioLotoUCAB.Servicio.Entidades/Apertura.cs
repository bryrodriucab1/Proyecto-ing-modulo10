using System;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{

    [Serializable]
    public class Apertura
    {
        [DataMember(Order = 1)]
        public int id_apertura { get; set; }

        [DataMember(Order = 2)]
        public Usuario usuario { get; set; }

        [DataMember(Order = 3)]
        public string fecha_apertura { get; set; }

        [DataMember(Order = 4)]
        public double monto_apertura { get; set; }

        [DataMember(Order = 5)]
        public string fecha_cierre { get; set; }

        [DataMember(Order = 6)]
        public double monto_cierre { get; set; }

        [DataMember(Order = 7)]
        public Estatus estatus { get; set; }
    }
}
