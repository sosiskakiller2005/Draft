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
    
    public partial class material_type
    {
        public int ID { get; set; }
        public string material_type1 { get; set; }
    
        public virtual materials materials { get; set; }
    }
}
