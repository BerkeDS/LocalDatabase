//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Local_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.Islemlers = new HashSet<Islemler>();
        }
    
        public int Id { get; set; }
        public string Ogrenci_Ad { get; set; }
        public string Ogrenci_Soyad { get; set; }
        public int Ogrenci_Numara { get; set; }
        public Nullable<int> Not1 { get; set; }
        public Nullable<int> Not2 { get; set; }
        public Nullable<int> Not3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Islemler> Islemlers { get; set; }
    }
}
