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
    
    public partial class Eskadrila
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eskadrila()
        {
            this.AvioTehnicars = new HashSet<AvioTehnicar>();
            this.Pilots = new HashSet<Pilot>();
        }
    
        public int ID_ESK { get; set; }
        public string GRB_ESK { get; set; }
        public string IME_ESK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvioTehnicar> AvioTehnicars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pilot> Pilots { get; set; }
    }
}