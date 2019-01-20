using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioLotoUCAB.Servicio.Entidades;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;

namespace ServicioLotoUCABcaja.Servicio.AccesoDatos.Dao
{
    public class DaoServiceCaja
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        static MySqlConnection Conexion = null;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static MySqlConnection getDBConnection()
        {
            if (Conexion == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["BaseIS"].ConnectionString;
                Conexion = new MySqlConnection(connectionString);
            }
            return Conexion;
        }
        public void desconectar()
        {
            if (Conexion != null)
            {
                Conexion.Close();
                Conexion.Dispose();
            }

        }

        public int verificartaquilla(int id)// verifica que el usuario taquilla exista
        {
            MensajeCaja mensaje = new MensajeCaja();
            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                Conexion = getDBConnection();
                Query = Conexion.CreateCommand();
                Query.CommandText = "SELECT * FROM TB_USUARIO  WHERE ID_USUARIO=@idusuario";
                Query.Parameters.AddWithValue("idusuario", id);
                Query.CommandType = CommandType.Text;
                Conexion.Open();
                MySqlDataReader reader = Query.ExecuteReader();
                int x = 0;
                while (reader.Read())
                {

                    x = Convert.ToInt32(reader[9]);// estatus de el usuario taquilla
                }
                desconectar();

                if (x != 0)// si x!= 0 es que encontroe l usuario taquilla
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch (MySqlException e)
            {


            }
            finally
            {
                desconectar();
            }

            return 0;
        }

        public Boolean verificarEstatus(int idcaja,int estatus)//verifica estatus de la caja que se desea abrir o cerrar
        {       //retorna true si la caja esta abierta y false si la caja esta cerrada

            //verificar estatus escribir query
            //con id de usuario
            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                Conexion = getDBConnection();
                Conexion.Open();
                Query.CommandText = "SELECT * FROM TB_APERTURA  WHERE ID_APERTURA=@idcaja";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                int x = 0;
                while (consultar.Read())
                {
                    x = Convert.ToInt32(consultar[6]);
                }
                desconectar();
                if (x == 2)//taquilla cerrada
                {
                    return false;
                }
                else {

                    return true;
                }

            }
            catch (MySqlException e)
            {

            }
            finally
            {
                desconectar();
            }
            return false;
        }

        public MensajeCaja abrircaja(int idcaja,int idusuario, float monto, int estatus)
        {
            MensajeCaja mensaje = new MensajeCaja();

            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                Conexion = getDBConnection();
                Query = Conexion.CreateCommand();
                Query.CommandText = "UPDATE TB_APERTURA SET FECHA_APERTURA=CURRENT_TIMESTAMP, MONTO_APERTURA=@monto, ESTATUS=@estatus WHERE ID_APERTURA=@id";
                Query.Parameters.AddWithValue("monto", monto);
                Query.Parameters.AddWithValue("estatus", estatus);
                Query.Parameters.AddWithValue("id", idcaja);
                Query.CommandType = CommandType.Text;
                Conexion.Open();

                if (Query.ExecuteNonQuery() > 0)
                    mensaje.set("se aperturo la caja correctamente");
                else
                    mensaje.set("Ya ha sido modificado");
                desconectar();
            }
            catch (MySqlException e)
            {
                mensaje.set("no se pudo abrir la caja dado a un error con la conexion a la base de datos");
            }
            finally
            {
                desconectar();
            }
            return mensaje;
        }

        public MensajeCaja cerrarcaja(int idcaja,int idusuario, float monto, int estatus)
        {
            MensajeCaja mensaje = new MensajeCaja();
            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                Conexion = getDBConnection();
                Query = Conexion.CreateCommand();
                Query.CommandText = "UPDATE TB_APERTURA SET FECHA_CIERRE=CURRENT_TIMESTAMP, MONTO_CIERRE=@monto, ESTATUS=@estatus WHERE ID_APERTURA=@id";
                Query.Parameters.AddWithValue("monto", monto);
                Query.Parameters.AddWithValue("estatus", estatus);
                Query.Parameters.AddWithValue("id", idcaja);
                Query.CommandType = CommandType.Text;
                Conexion.Open();

                if (Query.ExecuteNonQuery() > 0)
                    mensaje.set("se ha cerrado la caja correctamente");
                else
                    mensaje.set("Ya ha sido modificado");

                desconectar();
            }
            catch (MySqlException e)
            {
                mensaje.set("no se pudo cerrar la caja por error en la conexion con la base de datos");
            }
            finally
            {
                desconectar();
            }

            return mensaje;
        }
        public int existecaja(int idcaja)//verifica si una caja existe en base de datos
        {                                 //retorna 1 si existe 0 si no existe
            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                Conexion = getDBConnection();
                Query = Conexion.CreateCommand();
                Query.CommandText = "SELECT * FROM TB_APERTURA  WHERE ID_APERTURA=@idcaja";
                Query.Parameters.AddWithValue("idcaja", idcaja);
                Query.CommandType = CommandType.Text;
                Conexion.Open();
                MySqlDataReader reader = Query.ExecuteReader();
                int x = 0;
                while (reader.Read())
                {

                    x = Convert.ToInt32(reader[1]); //este es el ide de taquilla
                }
                desconectar();
                if (x == 0)// si x== 0 la caja no existe porque no encontro el usuario taquilla
                {
                    return 0;
                }
                else// si es diferente de x es que si encontro algo 
                {
                    return 1;
                }
        
            }
            catch (MySqlException e)
            {
               

            }
            finally
            {
                desconectar();
            }

            return 0;
        }

        public MensajeCaja crearcaja(int idcaja, int idusuario, float monto, int estatus)
        {           //crea una caja desde cero
            MensajeCaja mensaje = new MensajeCaja();
            try
            {
                log.Debug("Método: " + MethodBase.GetCurrentMethod().Name);
                Conexion = getDBConnection();
                Conexion.Open();
                Query = Conexion.CreateCommand();
                Query.CommandText = string.Format("INSERT INTO TB_APERTURA (ID_USUARIO, FECHA_APERTURA, FECHA_CIERRE, MONTO_APERTURA, MONTO_CIERRE, ESTATUS) VALUES (@0,CURRENT_TIMESTAMP,null, @3, null, @5);");
                Query.Parameters.Add(new MySqlParameter("0", idusuario));
                Query.Parameters.Add(new MySqlParameter("3", monto));
                Query.Parameters.Add(new MySqlParameter("5", estatus));

                var verificador = Query.ExecuteNonQuery();

                mensaje.set("Insert a la base de datos exitoso!");

                desconectar();
            }
            catch (MySqlException e)
            {
                mensaje.set("No se pudo crear la caja por un error en conexion con la base de datos");

            }
            finally
            {
                desconectar();
            }

            return mensaje;
        }

    }
}
