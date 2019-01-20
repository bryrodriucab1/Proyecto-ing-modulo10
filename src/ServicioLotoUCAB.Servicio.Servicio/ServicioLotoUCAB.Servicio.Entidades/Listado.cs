using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Clase de la entidad Jugada
    /// </summary>
    [DataContract]
    [Serializable]
    public class Listado
    {
        public int id_listado { get; set; }

        public string nombre_miembro { get; set; }

        public string valor { get; set; }

        public string tipo_miembro { get; set; }
    }
}

