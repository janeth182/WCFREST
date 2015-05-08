using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    
    public partial class MenusBE
    {
        [DataMember]
        public int iNivel { get; set; }
        [DataMember]
        public string xArbol { get; set; }
    }
}
