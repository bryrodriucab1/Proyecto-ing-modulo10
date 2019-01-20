using ServicioLotoUCABcaja.Servicio.Logica.Comand.ComandoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCABcaja.Servicio.Logica.Comand
{
    public class FabricaComandos
    {
        public static ComandoCaja FabricarComandoAbrirCaja()
        {
            return new ComandoCaja();
        }
        public static ComandoCaja FabricarComandoCierreCaja()
        {
            return new ComandoCaja();
        }

    }
}
