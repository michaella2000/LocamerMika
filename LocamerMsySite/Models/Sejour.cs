//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocamerMsySite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sejour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sejour()
        {
            this.Option_sejour = new HashSet<Option_sejour>();
            this.Emplacement = new HashSet<Emplacement>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date_debut { get; set; }
        public Nullable<System.DateTime> date_fin { get; set; }
        public Nullable<int> client_id { get; set; }
        public Nullable<int> type_sejour_id { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Option_sejour> Option_sejour { get; set; }
        public virtual Type_sejour Type_sejour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emplacement> Emplacement { get; set; }
    }
}
