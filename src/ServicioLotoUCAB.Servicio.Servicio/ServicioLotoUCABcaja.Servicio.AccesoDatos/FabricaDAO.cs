using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioLotoUCABcaja.Servicio.AccesoDatos.Dao;

namespace ServicioLotoUCABcaja.Servicio.AccesoDatos
{
    public class FabricaDAO
    {
        public static DaoServiceCaja crearDaoService()
        {
            return new DaoServiceCaja();
        }
    }
}
