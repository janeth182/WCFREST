using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    
    public partial class LoginsBE
    {
        [DataMember]
        public string xPassword { get; set; }
        [DataMember]
        public string xConstante { get; set; }
        [DataMember]
        public int iReferencia { get; set; }
        [DataMember]
        public string xHtml { get; set; }
    }
}
