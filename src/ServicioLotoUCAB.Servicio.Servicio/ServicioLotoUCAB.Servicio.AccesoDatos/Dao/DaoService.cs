using System;
using ServicioLotoUCAB.Servicio.Excepciones;

namespace ServicioLotoUCAB.Servicio.AccesoDatos.Dao
{
    public class DaoService
    {
        public string GetData(int value)
        {
            string resultado = string.Empty;
            try
            {
                //Intrumentacion Logger
                resultado = "Usted introdujo el valor " + value;
                //Intrumentacion Logger
            }
            catch(InvalidOperationException ex)
            {
                throw ExcepcionLoto(ex.Message);
            }
            catch (Exception ex)
            {
                //Intrumentacion Logger Error
                throw ;
            }
            finally
            {
                //Intrumentacion Logger final
            }
            return resultado;
        }
    }
}
