using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class RolesBE
    {
        [DataMember]
        public int iRol { get; set; }
        [DataMember]
        public string xRol { get; set; }
    }
}
