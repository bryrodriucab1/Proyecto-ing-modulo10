using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Jugada
    /// </summary>
    [DataContract]
    [Serializable]
    public class Jugada
    {
        [DataMember(Order = 1)]
        public int id_jugada { get; set; }

        [DataMember(Order = 2)]
        public Ticket ticket { get; set; }

        [DataMember(Order = 3)]
        public int id_item { get; set; }

        [DataMember(Order = 4)]
        public string valor_item { get; set; }

        [DataMember(Order = 5)]
        public string nombre_item { get; set; }

        [DataMember(Order = 6)]
        public int id_conjunto { get; set; }

        [DataMember(Order = 7)]
        public string nombre_conjunto { get; set; }

        [DataMember(Order = 8)]
        public double montoapuesta { get; set; }

        [DataMember(Order = 9)]
        public int id_juego { get; set; }

        [DataMember(Order = 10)]
        public string nombre_juego { get; set; }

        [DataMember(Order = 11)]
        public int id_sorteo { get; set; }

        [DataMember(Order = 12)]
        public string nombre_sorteo { get; set; }

        [DataMember(Order = 13)]
        public string premio { get; set; }

        [DataMember(Order = 14)]
        public Estatus estatus { get; set; }
    }
}
