using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    /// <summary>
    /// Enumerado que contiene los estatus que se manejan en el sistema.
    /// </summary>
    [DataContract]
    [Serializable]
    public enum Estatus
    {
        NoEstatus,
        Activo = 1,
        Inactivo,
        Eliminado
    }
}
