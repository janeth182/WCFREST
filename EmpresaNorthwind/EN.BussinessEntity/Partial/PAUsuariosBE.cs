using System;
using System.Runtime.Serialization;


namespace EN.BussinessEntity
{
    
    public partial class UsuariosBE
    {
        [DataMember]
        public System.Guid gSesion { get; set; }
        [DataMember]
        public string xRol { get; set; }
        [DataMember]
        public string xEstado { get; set; }
        [DataMember]
        public string xUsuarioCreador { get; set; }
        [DataMember]
        public string xRolCreador { get; set; }
        [DataMember]
        public string xUsuarioModificador { get; set; }
        [DataMember]
        public string xRolModificador { get; set; }
        [DataMember]
        public string xHtml { get; set; }
        [DataMember]
        public int iEstado { get; set; }
        [DataMember]
        public string xCodConfirmacion { get; set; }
        [DataMember]
        public bool lError { get; set; }
        [DataMember]
        public string xRespuesta { get; set; }
        [DataMember]
        public string xMensaje { get; set; }
    }
}
