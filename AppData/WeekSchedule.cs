//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeekClassSchedule.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class WeekSchedule
    {
        public long ClassroomId { get; set; }
        public long ClassNumber { get; set; }
        public long WeekDay { get; set; }
        public Nullable<long> ProfessorId { get; set; }
    
        public virtual Classroom Classroom { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
