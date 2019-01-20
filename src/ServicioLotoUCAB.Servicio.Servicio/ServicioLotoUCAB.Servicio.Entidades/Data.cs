using System;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class Data
    {
        [DataMember(Order = 1)]
        public Menu menu { get; set; }
    }
}
