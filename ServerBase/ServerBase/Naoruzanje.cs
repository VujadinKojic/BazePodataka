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
    
    public partial class Naoruzanje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Naoruzanje()
        {
            this.Uzimas = new HashSet<Uzima>();
        }
    
        public int LovacID_AV { get; set; }
        public int ElektroOpremaVazduhoplovaID_AT { get; set; }
    
        public virtual Lovac Lovac { get; set; }
        public virtual ElektroOpremaVazduhoplova ElektroOpremaVazduhoplova { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uzima> Uzimas { get; set; }
    }
}