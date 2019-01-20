using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Juego
    /// </summary>
    [DataContract]
    [Serializable]
    public class Juego
    {
        [DataMember(Order = 1)]
        public int id_juego { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 10)]
        public List<Conjunto> conjuntos { get; set; }

        [DataMember(Order = 11)]
        public TipoJuego tipojuego { get; set; }

        [DataMember(Order = 8)]
        public List<Item> items { get; set; }

        [DataMember(Order = 9)]
        public List<Sorteo> sorteos { get; set; }

        [DataMember(Order = 3)]
        public double max_venta { get; set; }

        [DataMember(Order = 4)]
        public double max_posible_perdida { get; set; }

        [DataMember(Order = 5)]
        public int max_ticket_item { get; set; }

        [DataMember(Order = 6)]
        public int max_ticket { get; set; }

        [DataMember(Order = 7)]
        public Estatus estatus { get; set; }

        [DataMember(Order = 8)]
        public Usuario usuariocreador { get; set; }

        [DataMember(Order = 9)]
        public int factor { get; set; }

        [DataMember(Order = 10)]
        public int tiempo_cierre { get; set; }

    }
}
