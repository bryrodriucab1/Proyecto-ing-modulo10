using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad OpcionMenu
    /// </summary>
    [DataContract]
    [Serializable]
    public class OpcionMenu
    {
        [DataMember(Order = 1)]
        public int id_opcionmenu { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 3)]
        public string descripcion { get; set; }

        [DataMember(Order = 4)]
        public string url { get; set; }

        [DataMember(Order = 5)]
        public int posicion { get; set; }

        [DataMember(Order = 6)]
        public Estatus estatus { get; set; }
    }
}
