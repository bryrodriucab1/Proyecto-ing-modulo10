using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{   [DataContract]
    public class MensajeCaja
    {[DataMember]
        public string mensaje { get; set; }

        public void set(string mensaje)
        {
            this.mensaje = mensaje;

        }
    }
}
