using EN.BussinessEntity;
using EN.DataAccess.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessLogic
{
    public class ENorthwindBL
    {
        #region Login
        public DatosEN regLogin(LoginsBE oLogins)
        {
            return new ENorthwindDA().regLogin(oLogins);
        }
        #endregion
        #region Usuarios
        public DatosEN addUsuarios(UsuariosBE oUsuarios)
        {
            return new ENorthwindDA().addUsuarios(oUsuarios);
        }

        public DatosEN lstUsuarios(UsuariosBE oUsuario)
        {
            return new ENorthwindDA().lstUsuarios(oUsuario);
        }
        #endregion
    }
}
