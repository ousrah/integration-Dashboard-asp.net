//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication15
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEPOT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPOT()
        {
            this.STOCKER = new HashSet<STOCKER>();
        }
    
        public int NUMDEP { get; set; }
        public string NOMDEP { get; set; }
        public string ADRDEP { get; set; }
        public string CPDEP { get; set; }
        public string VILLEDEP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCKER> STOCKER { get; set; }
    }
}
