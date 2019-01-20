using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Dominio
    /// </summary>
    [DataContract]
    [Serializable]
    public class Dominio
    {
        [DataMember(Order = 1)]
        public int id_dominio { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 3)]
        public string numeroidentificacion { get; set; }

        [DataMember(Order = 4)]
        public string direccion { get; set; }

        [DataMember(Order = 5)]
        public string telefono { get; set; }

        [DataMember(Order = 6)]
        public double porcentaje { get; set; }

        [DataMember(Order = 7)]
        public bool banqueo { get; set; }

        [DataMember(Order = 8)]
        public Usuario usuario { get; set; }

        [DataMember(Order = 9)]
        public Estatus estatus { get; set; }

        [DataMember(Order = 10)]
        public List<Impuesto> impuestos { get; set; }

        [DataMember(Order = 11)]
        public Usuario usuariocreador { get; set; }
    }
}
