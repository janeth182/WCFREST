using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class ConstantesBE
    {
        [DataMember]
        public short iConstante { get; set; }
        [DataMember]
        public string xCodigo { get; set; }
        [DataMember]
        public bool lDatoInt { get; set; }
        [DataMember]
        public Nullable<int> iDato { get; set; }
        [DataMember]
        public string xDato { get; set; }
        [DataMember]
        public string xDescripcion { get; set; }
        [DataMember]
        public string xToken { get; set; }
        [DataMember]
        public Nullable<bool> lActivo { get; set; }
    }
}
