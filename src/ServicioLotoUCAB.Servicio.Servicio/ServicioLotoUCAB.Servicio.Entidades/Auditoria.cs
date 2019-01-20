using System.Runtime.Serialization;


namespace ServicioLotoUCAB.Servicio.Entidades
{
    public class Auditoria
    {
        [DataMember(Order = 1)]
        public int id_auditoria { get; set; }

        [DataMember(Order = 5)]
        public int evento { get; set; }

        [DataMember(Order = 2)]
        public Usuario usuario { get; set; }

        [DataMember(Order = 3)]
        public string parametros { get; set; }

        [DataMember(Order = 5)]
        public string fecha_hora { get; set; }

        [DataMember(Order = 4)]
        public bool exito { get; set; }
    }
}
