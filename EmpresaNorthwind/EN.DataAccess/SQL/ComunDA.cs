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
    public class ComunDA
    {
        public string outMensajes(string xCodigo)
        {
            try
            {
                string xMensaje = string.Empty;

                SqlParameter[] paramsToStore = new SqlParameter[2];
                paramsToStore[0] = new SqlParameter("@xCodigo", SqlDbType.NVarChar, 50);
                paramsToStore[0].Value = xCodigo;
                paramsToStore[1] = new SqlParameter("@xMensaje", SqlDbType.VarChar, 1000);
                paramsToStore[1].Direction = ParameterDirection.Output;
                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlDBAdapter.GetConexion(), CommandType.StoredProcedure, "spl_outMensajes", paramsToStore))
                {
                    reader.NextResult();
                    xMensaje = paramsToStore[1].Value.ToString();
                }
                return xMensaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DatosEN regConstante(Nullable<Guid> gSesion, string xCodigo)
        {
            bool lError = true;
            string xRespuesta = string.Empty;
            string xMensaje = string.Empty;
            ConstantesBE resultado = new ConstantesBE();
            try
            {

                SqlParameter[] paramsToStore = new SqlParameter[4];
                paramsToStore[0] = new SqlParameter("@gSesion", SqlDbType.UniqueIdentifier);
                paramsToStore[0].Value = gSesion;
                paramsToStore[1] = new SqlParameter("@xCodigo", SqlDbType.VarChar, 50);
                paramsToStore[1].Value = xCodigo;
                paramsToStore[2] = new SqlParameter("@lError", SqlDbType.Bit);
                paramsToStore[2].Direction = ParameterDirection.Output;
                paramsToStore[3] = new SqlParameter("@xRespuesta", SqlDbType.VarChar, 30);
                paramsToStore[3].Direction = ParameterDirection.Output;
                //paramsToStore[4] = new SqlParameter("@xMensaje", SqlDbType.VarChar, 1000);
                //paramsToStore[4].Direction = ParameterDirection.Output;
                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlDBAdapter.GetConexion(), CommandType.StoredProcedure, "spl_regConstante", paramsToStore))
                {
                    //reader.NextResult();
                    //xMensaje = paramsToStore[1].Value.ToString();
                    reader.Read();
                    if (reader.HasRows && !reader.IsDBNull(reader.GetOrdinal("lDatoInt")))
                    {
                        resultado.lDatoInt = reader.GetBoolean(reader.GetOrdinal("lDatoInt"));
                        resultado.iDato = reader.GetInt32(reader.GetOrdinal("iDato"));
                        resultado.xDato = reader.GetString(reader.GetOrdinal("xDato"));
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
            return new DatosEN { Constantes = resultado, lError = lError, xRespuesta = xRespuesta, xMensaje = xMensaje };
        }
    }
}
