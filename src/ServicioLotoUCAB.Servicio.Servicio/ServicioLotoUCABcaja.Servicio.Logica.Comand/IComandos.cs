using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCABcaja.Servicio.Logica.Comand
{
    public interface IComando<abrircaja,cerrarcaja>
    {
      
        abrircaja abrirc(int idcaja,int idusuario, float monto, int estatus);
        cerrarcaja cerrarc(int idcaja,int idusuario, float monto, int estatus);
    }
}
