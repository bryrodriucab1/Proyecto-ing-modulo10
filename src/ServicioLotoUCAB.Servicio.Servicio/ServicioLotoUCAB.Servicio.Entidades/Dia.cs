using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Dia
    /// </summary>
    [DataContract]
    [Serializable]
    public class Dia
    {
        [DataMember(Order = 1)]
        public int id_dia { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 3)]
        public Estatus estatus { get; set; }
    }
}
