//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursach
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuComposition
    {
        public int? Id { get; set; }
        public Nullable<int> Menu { get; set; }
        public Nullable<int> DishComposition { get; set; }
    
        public virtual DishComposition DishComposition1 { get; set; }
        public virtual Menu Menu2 { get; set; }
    }
}
