//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instruction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instruction()
        {
            this.JournalAccounting = new HashSet<JournalAccounting>();
        }
    
        public int ID { get; set; }
        public string NameIns { get; set; }
        public int Instructor { get; set; }
        public System.DateTime DateCompletion { get; set; }
        public Nullable<System.DateTime> RePassDate { get; set; }
        public string violations { get; set; }
        public bool Planned { get; set; }
        public bool PrimeryIns { get; set; }
    
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalAccounting> JournalAccounting { get; set; }
    }
}
