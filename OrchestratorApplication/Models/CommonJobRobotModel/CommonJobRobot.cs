using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OrchestratorApplication.Models.JobsModel;
using OrchestratorApplication.Models.RobotsModel;
namespace OrchestratorApplication.Models.CommonJobRobotModel
{
    public class CommonJobRobot
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<StandardRobot> Robots { get; set; }
    }
}