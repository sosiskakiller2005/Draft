//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Draft.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public materials()
        {
            this.possible_supply = new HashSet<possible_supply>();
        }
    
        public int ID { get; set; }
        public string material_name { get; set; }
        public int material_type { get; set; }
        public string image { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public int min_amount { get; set; }
        public int pack_amount { get; set; }
        public int measure { get; set; }
    
        public virtual material_type material_type1 { get; set; }
        public virtual measure measure1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<possible_supply> possible_supply { get; set; }
    }
}
