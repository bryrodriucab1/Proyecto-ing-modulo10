using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class Resultado
    {
        [DataMember(Order = 1)]
        public int id_juego { get; set; }

        [DataMember(Order = 2)]
        public string nombre_juego { get; set; }

        [DataMember(Order = 3)]
        public int id_sorteo { get; set; }

        [DataMember(Order = 4)]
        public string hora { get; set; }

        [DataMember(Order = 5)]
        public int id_item { get; set; }

        [DataMember(Order = 6)]
        public int valor { get; set; }

        [DataMember(Order = 7)]
        public string nombre_item { get; set; }
    }
}

