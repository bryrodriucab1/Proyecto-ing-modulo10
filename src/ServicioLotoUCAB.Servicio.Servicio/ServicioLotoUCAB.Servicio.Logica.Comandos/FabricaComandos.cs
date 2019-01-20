using ServicioLotoUCAB.Servicio.Logica.Comandos.ComandosService;

namespace ServicioLotoUCAB.Servicio.Logica.Comandos
{
    public class FabricaComandos
    {
        public static ComandoGetData FabricarComandoGetData(int value)
        {
            return new ComandoGetData(value);
        }
    }
}
