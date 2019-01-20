using System;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Solicitud
    /// </summary>
    [DataContract]
    [Serializable]
    public class Solicitud
    {
        [DataMember(Order = 1)]
        public int id_solicitud { get; set; }

        [DataMember(Order = 2)]
        public double monto { get; set; }

        [DataMember(Order = 3)]
        public string codigoqr { get; set; }

        [DataMember(Order = 4)]
        public string codigosolicitud { get; set; }

        [DataMember(Order = 5)]
        public TipoOperacion tipooperacion { get; set; }

        [DataMember(Order = 6)]
        public Usuario usuario { get; set; }
    }
}