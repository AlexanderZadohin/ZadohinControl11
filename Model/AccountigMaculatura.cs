//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZadohinControl11.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountigMaculatura
    {
        public int id { get; set; }
        public Nullable<int> idClass { get; set; }
        public decimal KgPaper { get; set; }
        public Nullable<System.DateTime> DateCollect { get; set; }
    
        public virtual ClassSchool ClassSchool { get; set; }
    }
}
