using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using EN.BussinessEntity;


namespace EN.Interfaces
{
    [ServiceContract]
    public interface IENorthwind
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "outMensajes/{xCodigo}")]
        string outMensajes(string xCodigo);
        //[OperationContract]
        //[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "regConstante")]
        //DatosEN regConstante(Nullable<Guid> gSesion, string xCodigo);
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "regLogin")]
        DatosEN regLogin(LoginsBE oLogins);
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "addUsuarios")]
        DatosEN addUsuarios(UsuariosBE oUsuarios);
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "lstUsuarios")]
        DatosEN lstUsuarios(UsuariosBE oUsuario);
        
    }
}
