using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Conjunto
    /// </summary>
    [DataContract]
    [Serializable]
    public class Conjunto
    {
        [DataMember(Order = 1)]
        public int id_conjunto { get; set; }

        [DataMember(Order = 5)]
        public Juego juego { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 3)]
        public double monto { get; set; }

        [DataMember(Order = 4)]
        public double monto_max { get; set; }

        [DataMember(Order = 6)]
        public List<Item> items { get; set; }

        [DataMember(Order = 5)]
        public Estatus estatus { get; set; }

        [DataMember(Order = 7)]
        public string codigoacceso { get; set; }
    }
}
