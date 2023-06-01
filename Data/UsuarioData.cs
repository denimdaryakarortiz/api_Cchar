using api_app_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace api_app_2.Data
{
    public class UsuarioData
    {

        public static List<Usuario> Listar()
        {
            List<Usuario> oListaUsuario = new List<Usuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_consultar_USUARIO";
            try
            {
                if (objEst.Consultar(sentencia, false))
                {
                    SqlDataReader dr = objEst.Reader;
                    while (dr.Read())
                    {
                        oListaUsuario.Add(new Usuario()
                        {
                            IdU = Convert.ToInt32(dr["IdU"]),
                            Nombres = dr["Nombres"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Ciudad = dr["Ciudad"].ToString(),
                            FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())
                        });
                    }
                    return oListaUsuario;
                }
                else
                {
                    return oListaUsuario;
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

            
        }

        public static List<Usuario> Obtener(string idu)
        {
            List<Usuario> oListaUsuario = new List<Usuario>();
            ConexionBD objest = new ConexionBD();
            string sentencia;
            sentencia = "execute usp_obtener_USUARIO '" + idu + "'";
            if (objest.Consultar(sentencia, false))
            {
                SqlDataReader dr = objest.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Usuario()
                    {
                        IdU = Convert.ToInt32(dr["IdU"]),
                        Nombres = dr["Nombres"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Ciudad = dr["Ciudad"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }

        }












        public static bool registrarUsuario(Usuario ousuario)
        {
            ConexionBD objest = new ConexionBD();
            string sentencia;
            sentencia = "execute usp_registrar_usuario '" +
            ousuario.idu + "','" + ousuario.nombres + "','" + ousuario.telefono + "','" + ousuario.correo + "','" + ousuario.ciudad + "'";
            if (!objest.ejecutarsentencia(sentencia, false))
            {
                objest = null;
                return false;
            }
            else
            {
                objest = null;
                return true;
            }
        }

        public static bool actualizarUsuario(Usuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_actualizar_USUARIO '" +
            oUsuario.IdU + "','" + oUsuario.Nombres + "','" +
            oUsuario.Telefono + "','" + oUsuario.Correo + "','" +
            oUsuario.Ciudad + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }


        public static bool eliminarUsuario(string idu)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE  usp_eliminar_USUARIO '" + idu + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }




    }
}