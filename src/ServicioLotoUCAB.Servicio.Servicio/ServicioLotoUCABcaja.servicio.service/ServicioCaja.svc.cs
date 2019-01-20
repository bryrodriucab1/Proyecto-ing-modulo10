using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Net;
using System.Text;
using System.Reflection;
using ServicioLotoUCABcaja.Servicio.Logica.Comand;
using ServicioLotoUCAB.Servicio.Entidades;
using ServicioLotoUCABcaja.Servicio.Logica.Comand.ComandoService;

namespace ServicioLotoUCABcaja.servicio.service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IServicoCaja
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public MensajeCaja Abrircaja(int idcaja,int idusuario, float monto)
        {
            MensajeCaja mensaje = new MensajeCaja();
            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                ComandoCaja comandocaja = FabricaComandos.FabricarComandoAbrirCaja();
                mensaje = comandocaja.abrirc(idcaja,idusuario,monto,1);

            }
            catch(Exception ex)
            {
                log.Error("Error: " + ex.Message);
                mensaje.set("Error en conectarse a la base de datos "+ex.Message);
            }

            return mensaje;

        }

        public MensajeCaja Cerrarcaja(int idcaja,int idusuario, float monto)
        {
            MensajeCaja mensaje = new MensajeCaja();
            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                ComandoCaja comandocaja = FabricaComandos.FabricarComandoCierreCaja();
                mensaje = comandocaja.cerrarc(idcaja,idusuario,monto,2);
            }
            catch(Exception ex)
            {
                log.Error("Error: " + ex.Message);
                mensaje.set("Error en conectarse a la base de datos"+ex.Message);
            }
            return mensaje;
        }
    }
}
