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
    
    public partial class Emplacement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emplacement()
        {
            this.Sejour = new HashSet<Sejour>();
        }
    
        public string code { get; set; }
        public Nullable<int> capacite { get; set; }
        public Nullable<bool> terrasse { get; set; }
        public Nullable<int> categorie_id { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sejour> Sejour { get; set; }
    }
}