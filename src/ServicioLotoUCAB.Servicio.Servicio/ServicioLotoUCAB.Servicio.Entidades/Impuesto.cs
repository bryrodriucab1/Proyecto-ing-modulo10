using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Impuesto
    /// </summary>
    [DataContract]
    [Serializable]
    public class Impuesto
    {
        [DataMember(Order = 1)]
        public int id_impuesto { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 3)]
        public decimal porcentaje { get; set; }

        [DataMember(Order = 4)]
        public string aplicasobre { get; set; }

        [DataMember(Order = 5)]
        public Estatus estatus { get; set; }

    }
}
