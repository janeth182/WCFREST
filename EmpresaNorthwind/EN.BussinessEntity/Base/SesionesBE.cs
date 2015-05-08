using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class SesionesBE
    {
        [DataMember]
        public System.Guid gSesion { get; set; }
        [DataMember]
        public System.Guid gUsuario { get; set; }
        [DataMember]
        public string xIp { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dSesion { get; set; }
        [DataMember]
        public System.DateTime dActividad { get; set; }
    }
}
