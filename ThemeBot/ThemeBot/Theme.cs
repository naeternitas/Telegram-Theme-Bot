//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThemeBot
{
    using System;
    using System.Collections.Generic;
    
    public partial class Theme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Theme()
        {
            this.Ratings = new HashSet<Rating>();
            this.Downloads = new HashSet<Download>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ShowOwnerName { get; set; }
        public bool ShowOwnerUsername { get; set; }
        public int OwnerID { get; set; }
        public string FileName { get; set; }
        public string File_Id { get; set; }
        public string Photo_Id { get; set; }
        public Nullable<int> TimesChosen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Download> Downloads { get; set; }
    }
}
