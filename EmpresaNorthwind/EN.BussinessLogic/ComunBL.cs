using EN.BussinessEntity;
using EN.DataAccess.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessLogic
{
    public class ComunBL
    {
        public string outMensajes(string xCodigo)
        {
            return new ComunDA().outMensajes(xCodigo);
        }
        public DatosEN regConstante(Nullable<Guid> gSesion, string xCodigo)
        {
            return new ComunDA().regConstante(gSesion, xCodigo);
        }
    }
}
