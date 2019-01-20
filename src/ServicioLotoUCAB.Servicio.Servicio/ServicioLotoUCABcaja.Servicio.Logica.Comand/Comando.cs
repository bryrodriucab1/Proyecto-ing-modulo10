using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCABcaja.Servicio.Logica.Comand
{
    public abstract class Comando<abrircaja,cerrarcaja>: IComando<abrircaja,cerrarcaja>
    {
        public abstract abrircaja abrirc(int idcaja,int idusuario, float monto, int estatus);
        public abstract cerrarcaja cerrarc(int idcaja,int idusuario, float monto, int estatus);






    }
}
