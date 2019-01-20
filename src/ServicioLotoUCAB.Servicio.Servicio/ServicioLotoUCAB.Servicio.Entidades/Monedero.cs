using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Monedero
    /// </summary>
    [DataContract]
    [Serializable]
    public class Monedero
    {
        [DataMember(Order = 1)]
        public int id_operacion { get; set; }

        [DataMember(Order = 2)]
        public int id_usuario { get; set; }

        [DataMember(Order = 3)]
        public double monto { get; set; }

        [DataMember(Order = 4)]
        public string fecha_hora { get; set; }

        [DataMember(Order = 5)]
        public TipoOperacion tipooperacion { get; set; }
    }
}
