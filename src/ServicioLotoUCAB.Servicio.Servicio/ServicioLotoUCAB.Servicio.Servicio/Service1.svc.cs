using ServicioLotoUCAB.Servicio.Logica.Comandos;
using ServicioLotoUCAB.Servicio.Logica.Comandos.ComandosService;
using System;
using System.Net;
using System.ServiceModel.Web;


namespace ServicioLotoUCAB.Servicio.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            string resultado = string.Empty;
            try
            {
                //Intrumentacion Logger
                ComandoGetData comandoGetData =
                  FabricaComandos.FabricarComandoGetData(value);
                resultado = comandoGetData.Ejecutar();

                //Intrumentacion Logger
            }
            //Implementar las excepciones propias
            catch(Exception ex)
            {
                //Intrumentacion Logger Error
                throw new WebFaultException<string>(ex.Message,
                   HttpStatusCode.InternalServerError);
            }
            return resultado;
        }
    }
}
