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
    
    public partial class ReviewRequest
    {
        public string Queue { get; set; }
        public string Status { get; set; }
        public string Reference { get; set; }
        public string Revision { get; set; }
        public string Priority { get; set; }
        public string Deadline { get; set; }
        public string Robot { get; set; }
        public string Exception { get; set; }
        public string Time_of_failure { get; set; }
        public int ReviewID { get; set; }
    }
}
