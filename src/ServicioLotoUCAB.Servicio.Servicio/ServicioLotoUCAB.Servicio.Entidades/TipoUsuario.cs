using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad TipoUsuario
    /// </summary>
    [DataContract]
    [Serializable]
    public class TipoUsuario
    {
        [DataMember(Order = 1)]
        public int id_tipousuario { get; set; }

        [DataMember(Order = 2)]
        public string descripcion { get; set; }

        [DataMember(Order = 4)]
        public List<OpcionMenu> opcionesmenu { get; set; }

        [DataMember(Order = 3)]
        public Estatus estatus { get; set; }
    }
}
