using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public class DatosEN
    {
        [DataMember]
        public UsuariosBE Usuario { get; set; }
        [DataMember]
        public LoginsBE Login { get; set; }
        [DataMember]
        public ConstantesBE Constantes { get; set; }
        [DataMember]
        public List<MenusBE> ListaMenus { get; set; }
        [DataMember]
        public List<UsuariosBE> ListaUsuarios { get; set; }
        [DataMember]
        public List<EstadosBE> ListaEstados { get; set; }
        [DataMember]
        public List<RolesBE> ListaRoles { get; set; }
        [DataMember]
        public bool lError { get; set; }
        [DataMember]
        public string xRespuesta { get; set; }
        [DataMember]
        public string xMensaje { get; set; }
        [DataMember]
        public int iPagina { get; set; }
        [DataMember]
        public int iPaginas { get; set; }
        
    }
    public struct Respuestas
    {
        public const string RESPUESTA_OK = "RESPUESTA_OK";
        public const string SESION_ERROR = "SESION_ERROR";
    }
}
