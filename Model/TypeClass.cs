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
    
    public partial class TypeClass
    {
        public TypeClass()
        {
            this.ClassSchool = new HashSet<ClassSchool>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<ClassSchool> ClassSchool { get; set; }
    }
}