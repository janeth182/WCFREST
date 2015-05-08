using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EN.BussinessEntity
{
    [DataContract]
    public partial class MenusBE
    {
        [DataMember]
        public int iMenu { get; set; }
        [DataMember]
        public int iMenuPadre { get; set; }
        [DataMember]
        public string xMenu { get; set; }
        [DataMember]
        public string xDescripcion { get; set; }
        [DataMember]
        public string xRutaImagen { get; set; }
        [DataMember]
        public string xCss { get; set; }
        [DataMember]
        public string xRutaPagina { get; set; }
        [DataMember]
        public int iOrden { get; set; }
        [DataMember]
        public Nullable<bool> lVisible { get; set; }
        [DataMember]
        public Nullable<bool> lActivo { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dCreado { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dModificado { get; set; }
        
    }
}
