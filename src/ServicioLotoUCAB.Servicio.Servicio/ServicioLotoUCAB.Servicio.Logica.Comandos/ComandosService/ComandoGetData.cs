using ServicioLotoUCAB.Servicio.AccesoDatos;
using ServicioLotoUCAB.Servicio.AccesoDatos.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Logica.Comandos.ComandosService
{
    public class ComandoGetData : Comando<string>
    {
        #region Atributos
        private readonly int _value;
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        #region Constructor

        public ComandoGetData(int value)
        {
            _value = value;
        }

        #endregion

        /// <summary>
        /// Método que ejecuta las operaciones
        /// </summary>
        /// <returns></returns>
        public override string Ejecutar()
        {
            //Intrumentacion Logger

            DaoService dao = FabricaDAO.crearDaoService();
            string respuesta = dao.GetData(_value);

            //Intrumentacion Logger

            return respuesta;
        }

    }
}
