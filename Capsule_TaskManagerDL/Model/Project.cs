//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capsule_TaskManagerDL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public Project()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        public int Project_ID { get; set; }
        public string Project1 { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> Manager_ID { get; set; }
        public Nullable<int> Is_Active { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Task> Tasks { get; set; }
    }
}