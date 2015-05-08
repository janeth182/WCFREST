using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class UsuariosBE
    {
        [DataMember]
        public System.Guid gUsuario { get; set; }
        [DataMember]
        public string xUsuario { get; set; }
        [DataMember]
        public string xNombres { get; set; }
        [DataMember]
        public string xApellidos { get; set; }
        [DataMember]
        public string xEmail { get; set; }
        [DataMember]
        public string xDocIdentidad { get; set; }
        [DataMember]
        public string xMovil { get; set; }
        [DataMember]
        public string xFijo { get; set; }
        [DataMember]
        public string xDireccion { get; set; }
        [DataMember]
        public string fFoto { get; set; }
        [DataMember]
        public int iRol { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dCreado { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dModificado { get; set; }
        
    }
}
