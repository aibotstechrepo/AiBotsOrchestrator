using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrchestratorApplication.Models;
using OrchestratorApplication.Models.CommonJobRobotModel;
using OrchestratorApplication.Models.JobsModel;
using OrchestratorApplication.Models.RobotsModel;

namespace OrchestratorApplication.Controllers
{
    public class JobsController : Controller
    {
        OrchestratorDBEntities4 Jbosdb = new OrchestratorDBEntities4();
        OrchestratorDBEntities13 Robotdb = new OrchestratorDBEntities13();
        // GET: Jobs
        public ActionResult Index()
        {
            CommonJobRobot model = new CommonJobRobot();

            model.Jobs = Jbosdb.Jobs;
            model.Robots = Robotdb.StandardRobots;
            //using (OrchestratorDBEntities4 Jbosdb=new OrchestratorDBEntities4())
            //{
            //    model.Jobs = Jbosdb.Jobs;
            //    return View(model.JobsM..Jobs.ToList());
            //}
            return View(model);
               
            // Get Result  
            //model.ResultSetVM.ResultSet = this.LoadData();
            //return View(model);
        }


        
    }
}