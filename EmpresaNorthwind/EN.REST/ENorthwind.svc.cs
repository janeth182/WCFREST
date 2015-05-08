using EN.BussinessEntity;
using EN.BussinessLogic;
using EN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EN.REST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ENorthwind" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ENorthwind.svc or ENorthwind.svc.cs at the Solution Explorer and start debugging.
    public class ENorthwind : IENorthwind
    {
        #region Login
        public DatosEN regLogin(LoginsBE oLogins)
        {
            return new ENorthwindBL().regLogin(oLogins);
        }
        #endregion
        #region Usuarios
        public DatosEN addUsuarios(UsuariosBE oUsuarios)
        {
            return new ENorthwindBL().addUsuarios(oUsuarios);
        }

        public DatosEN lstUsuarios(UsuariosBE oUsuario)
        {
            return new ENorthwindBL().lstUsuarios(oUsuario);
        }
        #endregion
        public string outMensajes(string xCodigo)
        {
            return new ComunBL().outMensajes(xCodigo);
        }
        //public DatosEN regConstante(Nullable<Guid> gSesion, string xCodigo)
        //{
        //    return new ComunBL().regConstante(gSesion, xCodigo);
        //}
    }
}
