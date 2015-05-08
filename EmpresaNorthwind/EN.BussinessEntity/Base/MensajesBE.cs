using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class MensajesBE
    {
        [DataMember]
        public int iMensaje { get; set; }
        [DataMember]
        public string xCodigo { get; set; }
        [DataMember]
        public string xMensaje { get; set; }
        [DataMember]
        public string xDescripcion { get; set; }
        [DataMember]
        public Nullable<bool> lActivo { get; set; }
    }
}
