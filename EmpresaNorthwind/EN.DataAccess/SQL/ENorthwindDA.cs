using EN.Adapters;
using EN.BussinessEntity;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN.DataAccess.SQL
{
    public class ENorthwindDA
    {
        #region Logins
        public DatosEN regLogin(LoginsBE oLogins)
        {
            bool lError = true;
            string xRespuesta = string.Empty;
            string xMensaje = string.Empty;
            UsuariosBE resultado = new UsuariosBE();
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[4];
                paramsToStore[0] = new SqlParameter("@xUserName", SqlDbType.VarChar, 50);
                paramsToStore[0].Value = oLogins.xUserName;
                paramsToStore[1] = new SqlParameter("@pHash", SqlDbType.VarChar, -1);
                paramsToStore[1].Value = oLogins.xPassword;
                paramsToStore[2] = new SqlParameter("@lError", SqlDbType.Bit);
                paramsToStore[2].Direction = ParameterDirection.Output;
                paramsToStore[3] = new SqlParameter("@xRespuesta", SqlDbType.VarChar, 30);
                paramsToStore[3].Direction = ParameterDirection.Output;

                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlDBAdapter.GetConexion(), CommandType.StoredProcedure, "spl_regLogin", paramsToStore))
                {
                    reader.Read();
                    if (reader.HasRows && !reader.IsDBNull(reader.GetOrdinal("gSesion")))
                    {
                        resultado.gSesion = reader.GetGuid(reader.GetOrdinal("gSesion"));
                        resultado.xEmail = reader.GetString(reader.GetOrdinal("xEmail"));
                        resultado.xNombres = reader.GetString(reader.GetOrdinal("xNombres"));
                        resultado.xApellidos = reader.GetString(reader.GetOrdinal("xApellidos"));
                        resultado.fFoto = reader.GetString(reader.GetOrdinal("fFoto"));
                        resultado.iRol = reader.GetInt32(reader.GetOrdinal("iRol"));
                        resultado.xRol = reader.GetString(reader.GetOrdinal("xRol"));
                    }
                    reader.NextResult();
                    lError = (bool)paramsToStore[2].Value;
                    xRespuesta = paramsToStore[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                xRespuesta = "EXCEPCION";
                xMensaje = ex.Message;
            }
            return new DatosEN { Usuario = resultado, lError = lError, xRespuesta = xRespuesta, xMensaje = xMensaje };
        }
        #endregion
        #region Usuario
        public DatosEN addUsuarios(UsuariosBE oUsuarios)
        {
            bool lError = true;
            string xRespuesta = string.Empty;
            string xMensaje = string.Empty;
            UsuariosBE resultado = new UsuariosBE();
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[12];
                paramsToStore[0] = new SqlParameter("@gSesion", SqlDbType.UniqueIdentifier);
                paramsToStore[0].Value = oUsuarios.gSesion;
                paramsToStore[1] = new SqlParameter("@xUsuario", SqlDbType.VarChar, 20);
                paramsToStore[1].Value = oUsuarios.xUsuario;
                paramsToStore[2] = new SqlParameter("@xNombres", SqlDbType.NVarChar, 50);
                paramsToStore[2].Value = oUsuarios.xNombres;
                paramsToStore[3] = new SqlParameter("@xApellidos", SqlDbType.NVarChar, 100);
                paramsToStore[3].Value = oUsuarios.xApellidos;
                paramsToStore[4] = new SqlParameter("@xEmail", SqlDbType.VarChar, 50);
                paramsToStore[4].Value = oUsuarios.xEmail;
                paramsToStore[5] = new SqlParameter("@xDocIdentidad", SqlDbType.VarChar, 20);
                paramsToStore[5].Value = oUsuarios.xDocIdentidad;
                paramsToStore[6] = new SqlParameter("@xMovil", SqlDbType.VarChar, 20);
                paramsToStore[6].Value = oUsuarios.xMovil;
                paramsToStore[7] = new SqlParameter("@xFijo", SqlDbType.VarChar, 20);
                paramsToStore[7].Value = oUsuarios.xFijo;
                paramsToStore[8] = new SqlParameter("@xDireccion", SqlDbType.VarChar, 200);
                paramsToStore[8].Value = oUsuarios.xDireccion;
                paramsToStore[9] = new SqlParameter("@iRol", SqlDbType.Int);
                paramsToStore[9].Value = oUsuarios.iRol;
                paramsToStore[10] = new SqlParameter("@lError", SqlDbType.Bit);
                paramsToStore[10].Direction = ParameterDirection.Output;
                paramsToStore[11] = new SqlParameter("@xRespuesta", SqlDbType.VarChar, 30);
                paramsToStore[11].Direction = ParameterDirection.Output;

                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlDBAdapter.GetConexion(), CommandType.StoredProcedure, "spl_addUsuarios", paramsToStore))
                {
                    reader.Read();
                    if (reader.HasRows && !reader.IsDBNull(reader.GetOrdinal("gUsuario")))
                    {
                        resultado.gUsuario = reader.GetGuid(reader.GetOrdinal("gUsuario"));
                        resultado.xEmail = reader.GetString(reader.GetOrdinal("xEmail"));
                        resultado.xCodConfirmacion = reader.GetString(reader.GetOrdinal("xCodConfirmacion"));
                    }
                    reader.NextResult();
                    lError = (bool)paramsToStore[10].Value;
                    xRespuesta = paramsToStore[11].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                xRespuesta = "EXCEPCION";
                xMensaje = ex.Message;
            }
            return new DatosEN { Usuario = resultado, lError = lError, xRespuesta = xRespuesta, xMensaje = xMensaje };
        }

        public DatosEN lstUsuarios(UsuariosBE oUsuario)
        {
            bool lError = true;
            string xRespuesta = string.Empty;
            string xMensaje = string.Empty;
            List<UsuariosBE> resultado = new List<UsuariosBE>();
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[3];
                paramsToStore[0] = new SqlParameter("@gSesion", SqlDbType.UniqueIdentifier);
                paramsToStore[0].Value = oUsuario.gSesion;
                //paramsToStore[1] = new SqlParameter("@xUsuario", SqlDbType.VarChar, 20);
                //paramsToStore[1].Value = oUsuario.xUsuario;
                //paramsToStore[2] = new SqlParameter("@xNombres", SqlDbType.NVarChar, 50);
                //paramsToStore[2].Value = oUsuario.xNombres;
                //paramsToStore[3] = new SqlParameter("@xApellidos", SqlDbType.NVarChar, 100);
                //paramsToStore[3].Value = oUsuario.xApellidos;
                //paramsToStore[4] = new SqlParameter("@xEmail", SqlDbType.VarChar, 50);
                //paramsToStore[4].Value = oUsuario.xEmail;
                //paramsToStore[5] = new SqlParameter("@iRol", SqlDbType.Int);
                //paramsToStore[5].Value = oUsuario.iRol;
                //paramsToStore[6] = new SqlParameter("@iEstado", SqlDbType.Int);
                //paramsToStore[6].Value = oUsuario.iEstado;
                paramsToStore[1] = new SqlParameter("@lError", SqlDbType.Bit);
                paramsToStore[1].Direction = ParameterDirection.Output;
                paramsToStore[2] = new SqlParameter("@xRespuesta", SqlDbType.VarChar, 30);
                paramsToStore[2].Direction = ParameterDirection.Output;
                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlDBAdapter.GetConexion(), CommandType.StoredProcedure, "spl_lstUsuarios", paramsToStore))
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows && !reader.IsDBNull(reader.GetOrdinal("gUsuario")))
                        {
                            UsuariosBE usr = new UsuariosBE()
                            {
                                gUsuario = reader.GetGuid(reader.GetOrdinal("gUsuario")),
                                xUsuario = reader.GetString(reader.GetOrdinal("xUsuario")),
                                xNombres = reader.GetString(reader.GetOrdinal("xNombres")),
                                xApellidos = reader.GetString(reader.GetOrdinal("xApellidos")),
                                xRol = reader.GetString(reader.GetOrdinal("xRol")),
                                xEmail = reader.GetString(reader.GetOrdinal("xEmail")),
                                xEstado = reader.GetString(reader.GetOrdinal("xEstado")),
                            };
                            resultado.Add(usr);
                        }
                    }
                    reader.NextResult();
                    lError = (bool)paramsToStore[1].Value;
                    xRespuesta = paramsToStore[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                xRespuesta = "EXCEPCION";
                xMensaje = ex.Message;
            }
            return new DatosEN { ListaUsuarios = resultado, lError = lError, xRespuesta = xRespuesta, xMensaje = xMensaje };
        }
#endregion
    }
}
