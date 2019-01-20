using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioLotoUCAB.Servicio.Entidades;
using ServicioLotoUCABcaja.Servicio.AccesoDatos;
using ServicioLotoUCABcaja.Servicio.AccesoDatos.Dao;
using ServicioLotoUCABcaja.Servicio.Exepciones;

namespace ServicioLotoUCABcaja.Servicio.Logica.Comand.ComandoService
{
    public class ComandoCaja:Comando<MensajeCaja,MensajeCaja>
    {

        public override MensajeCaja abrirc(int idcaja,int idusuario, float monto, int estatus)
        {
            MensajeCaja mensaje = new MensajeCaja();
            DaoServiceCaja dao = FabricaDAO.crearDaoService();
            //int resultado = dao.abrircaja(idusuario,fechaapertura,monto, estatus);
            try
            {
                if (idusuario != 0 || idcaja != 0 || monto!=0)// verificar que usuario taquilla o usuario caja sea 0
                {
                     if (dao.verificartaquilla(idusuario) == 1)// el usuario taquilla existe
                      {
                        if (dao.existecaja(idcaja) == 1)//verifica si la caja existe
                        {
                            if (dao.verificarEstatus(idcaja, estatus) == false)//verifica que la caja no este abierta
                            {
                                mensaje=dao.abrircaja(idcaja, idusuario, monto, estatus);
                            }
                            else
                            {
                                throw new ExepcionEstatus();
                            }
                        }
                        else
                        {
                           mensaje=dao.crearcaja(idcaja, idusuario, monto, estatus);
                        }

                    }
                    else
                    {
                        throw new ExepcionTaquillaNoExiste();
                    }
                }
                else
                {
                    throw new ExepcionVariablesErroneas();
                }
            
            }
            catch(ExepcionVariablesErroneas ex)
            {
                mensaje.set("Los parametros proporcionados no son los adecuados");
            }
            catch(ExepcionTaquillaNoExiste ex)
            {
                mensaje.set("El usuario taquilla no es valido");

            }
            catch(ExepcionEstatus ex)
            {
                mensaje.set("La Caja que desea abir ya se encuentra abierta");
            }

            return mensaje;
        }

        public override MensajeCaja cerrarc(int idcaja,int idusuario, float monto, int estatus)
        {
            MensajeCaja mensaje = new MensajeCaja();
            DaoServiceCaja dao = FabricaDAO.crearDaoService();
            //int resultado = dao.cerrarcaja(idcaja,idusuario,fechacierre,monto,estatus);
            try
            {
                if (idcaja!=0 || idusuario!=0 ) {//verificar que usuario taquilla y usuario caja sean iugla a 0 

                    if (dao.verificartaquilla(idusuario) == 1)//verifica que usuario taquilla exista
                    {
                        if (dao.existecaja(idcaja) != 0)
                        {
                            if (dao.verificarEstatus(idcaja, estatus) == true)//verifica que la caja este abierta
                            {
                                mensaje = dao.cerrarcaja(idcaja, idusuario, monto, estatus);
                            }
                            else
                            {
                                throw new ExepcionEstatus();
                            }
                        }
                        else
                        {
                            throw new ExepcionCajaNoExiste();
                        }
                    }
                    else
                    {
                        throw new ExepcionTaquillaNoExiste();
                    }
                }
                else
                {
                    throw new ExepcionVariablesErroneas();
                }
            }
            catch(ExepcionVariablesErroneas ex)
            {
                mensaje.set("Los parametros proporcionados no son los adecuados");
            }
            catch(ExepcionTaquillaNoExiste ex)
            {
                mensaje.set("El usuario Taquilla no existe");


            }
            catch(ExepcionCajaNoExiste ex)
            {
                mensaje.set("la caja que desea cerrar no existe");
            }
            catch(ExepcionEstatus ex)
            {
                mensaje.set("La caja que desea cerrar ya se encuentra cerrada actualmente");
            }

            return mensaje;
        }
    }
}
