using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Sorteo
    /// </summary>
    [DataContract]
    [Serializable]
    public class Sorteo
    {
        [DataMember(Order = 1)]
        public int id_sorteo { get; set; }

        [DataMember(Order = 5)]
        public Juego juego { get; set; }

        [DataMember(Order = 4)]
        public List<Dia> dias { get; set; }

        [DataMember(Order = 2)]
        public string hora { get; set; }

        [DataMember(Order = 6)]
        public List<Item> items { get; set; }

        [DataMember(Order = 3)]
        public Estatus estatus { get; set; }
    }
}
