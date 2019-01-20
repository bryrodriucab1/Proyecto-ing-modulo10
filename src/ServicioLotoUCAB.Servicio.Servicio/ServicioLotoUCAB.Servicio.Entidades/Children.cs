using System;
using System.Runtime.Serialization;


namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class Children
    {
        [DataMember(Order = 1)]
        public string path { get; set; }

        [DataMember(Order = 2)]
        public Data data { get; set; }

    }
}
