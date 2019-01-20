using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Usuario
    /// </summary>
    [DataContract]
    [Serializable]
    public class Usuario
    {
        [DataMember(Order = 1)]
        public int id_usuario { get; set; }

        [DataMember(Order = 2)]
        public string nombre { get; set; }

        [DataMember(Order = 3)]
        public string apellido { get; set; }

        [DataMember(Order = 4)]
        public string numeroidentificacion { get; set; }

        [DataMember(Order = 5)]
        public string usuario { get; set; }

        [DataMember(Order = 6)]
        public string password { get; set; }

        [DataMember(Order = 7)]
        public string correoelectronico { get; set; }

        [DataMember(Order = 8)]
        public Estatus estatus { get; set; }

        [DataMember(Order = 9)]
        public Usuario padre { get; set; }

        [DataMember(Order = 10)]
        public Dominio dominio { get; set; }

        [DataMember(Order = 11)]
        public TipoUsuario tipousuario { get; set; }

        [DataMember(Order = 12)]
        public List<Juego> juegos { get; set; }

        [DataMember(Order = 13)]
        public List<Sorteo> sorteos { get; set; }

        [DataMember(Order = 14)]
        public List<Conjunto> conjuntos { get; set; }

        [DataMember(Order = 15)]
        public List<OpcionMenu> opcionesmenu { get; set; }

        [DataMember(Order = 16)]
        public string fecha_desde { get; set; }

        [DataMember(Order = 17)]
        public string fecha_hasta { get; set; }

        [DataMember(Order = 18)]
        public int caducidad { get; set; }

        [DataMember(Order = 19)]
        public int id_tipousuarioconsulta { get; set; }

        [DataMember(Order = 20)]
        public double saldo_disponible { get; set; }

    }
}
