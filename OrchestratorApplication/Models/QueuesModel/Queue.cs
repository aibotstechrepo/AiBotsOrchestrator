//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrchestratorApplication.Models.QueuesModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Queue
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string In_progress { get; set; }
        public string Remaining { get; set; }
        public string Avg_time { get; set; }
        public string Success { get; set; }
        public string App_exception { get; set; }
        public string BIZ_exc { get; set; }
        public Nullable<int> Retries { get; set; }
        public int QueueID { get; set; }
    }
}