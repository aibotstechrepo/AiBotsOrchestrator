using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OrchestratorApplication.Models.MachineModel
{
    public class StdMachine
    {
        [Required(ErrorMessage = "Enter name")]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Installed_version { get; set; }

        public virtual StandardMachine StandardMachine1 { get; set; }
        public virtual StandardMachine StandardMachine2 { get; set; }
    }
}