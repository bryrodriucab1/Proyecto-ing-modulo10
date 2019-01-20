using System;
using System.Runtime.Serialization;
namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad TipoOperacion
    /// </summary>
    [DataContract]
    [Serializable]
    public class TipoOperacion
    {
        [DataMember(Order = 1)]
        public int id_tipooperacion { get; set; }

        [DataMember(Order = 2)]
        public string descripcion { get; set; }

        [DataMember(Order = 3)]
        public string operacion { get; set; }

        [DataMember(Order = 4)]
        public string estatus { get; set; }
    }
}
