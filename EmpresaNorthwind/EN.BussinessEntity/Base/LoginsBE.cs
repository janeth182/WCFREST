using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class LoginsBE
    {
        [DataMember]
        public System.Guid gUsuario { get; set; }
        [DataMember]
        public string xUserName { get; set; }
        [DataMember]
        public byte[] pPassword { get; set; }
        [DataMember]
        public int iEstado { get; set; }
        [DataMember]
        public string xCodConfirmacion { get; set; }
        [DataMember]
        public int iFallas { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dUltimoLogin { get; set; }
        [DataMember]
        public System.DateTime dModificado { get; set; }

    }
}
