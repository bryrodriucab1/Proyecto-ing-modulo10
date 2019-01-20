using System;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class TipoJuego
    {
        [DataMember(Order = 1)]
        public int id_tipojuego { get; set; }

        [DataMember(Order = 2)]
        public string descripcion { get; set; }

        [DataMember(Order = 3)]
        public string pagina { get; set; }

        [DataMember(Order = 4)]
        public Estatus estatus { get; set; }
    }
}
