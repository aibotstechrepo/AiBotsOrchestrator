//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrchestratorApplication.Models.SchedulesModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public string Name { get; set; }
        public string Process { get; set; }
        public string Environment { get; set; }
        public string Tigger_details { get; set; }
        public string Next_runtime { get; set; }
        public string Stop_after { get; set; }
    }
}
