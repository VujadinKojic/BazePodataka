//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class AvioTehnicar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AvioTehnicar()
        {
            this.PretpoletniPregleds = new HashSet<PretpoletniPregled>();
        }
    
        public int ID_AT { get; set; }
        public string IME_AT { get; set; }
        public int BG_AT { get; set; }
        public Nullable<int> RadionicaID_RAD { get; set; }
        public Nullable<int> EskadrilaID_ESK { get; set; }
        public TIP_AT TIP_AT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PretpoletniPregled> PretpoletniPregleds { get; set; }
        public virtual Radionica Radionica { get; set; }
        public virtual Eskadrila Eskadrila { get; set; }
    }
}