using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    public class Product
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }

        [DataMember(Order = 2)]
        public DateTime ExpiryDate { get; set; }

        [DataMember(Order = 3)]
        public Decimal Price { get; set; }

        [DataMember(Order = 4)]
        public string[] Sizes { get; set; }
    }
}
