using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class EstadosBE
    {   
        [DataMember]   
        public int iEstado { get; set; }
        [DataMember]
        public string xEstado { get; set; }
    }
}
