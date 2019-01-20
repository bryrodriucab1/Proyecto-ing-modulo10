using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Ticket
    /// </summary>
    [DataContract]
    [Serializable]
    public class Ticket
    {
        [DataMember(Order = 1)]
        public int id_ticket { get; set; }

        [DataMember(Order = 7)]
        public Usuario usuario { get; set; }

        [DataMember(Order = 6)]
        public List<Jugada> jugadas { get; set; }

        [DataMember(Order = 2)]
        public string serial { get; set; }

        [DataMember(Order = 3)]
        public string fecha { get; set; }

        [DataMember(Order = 5)]
        public Estatus estatus { get; set; }

        [DataMember(Order = 4)]
        public string monto_pagado { get; set; }
    }
}
