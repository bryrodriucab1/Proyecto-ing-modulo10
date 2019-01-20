using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class Menu
    {
        [DataMember(Order = 1)]
        public string title { get; set; }

        [DataMember(Order = 2)]
        public string icon { get; set; }

        [DataMember(Order = 3)]
        public bool selected { get; set; }

        [DataMember(Order = 4)]
        public bool expanded { get; set; }

        [DataMember(Order = 4)]
        public int order { get; set; }
    }
}
