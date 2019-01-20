using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Item
    /// </summary>
    [DataContract]
    [Serializable]
    public class Item
    {
        [DataMember(Order = 1)]
        public int id_item { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 3)]
        public string valor { get; set; }

        [DataMember(Order = 4)]
        public int cupo { get; set; }

        [DataMember(Order = 5)]
        public double monto { get; set; }

        [DataMember(Order = 6)]
        public double monto_max { get; set; }

        [DataMember(Order = 7)]
        public int cupo_max { get; set; }

        [DataMember(Order = 8)]
        public double monto_disponible { get; set; }

        [DataMember(Order = 9)]
        public int cupo_disponible { get; set; }

        [DataMember(Order = 10)]
        public List<Conjunto> Conjuntos { get; set; }

        [DataMember(Order = 11)]
        public Estatus estatus { get; set; }
    }
}
