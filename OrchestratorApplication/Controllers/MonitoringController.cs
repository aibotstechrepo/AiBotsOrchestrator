using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrchestratorApplication.Controllers
{
    public class MonitoringController : Controller
    {
        // GET: Monitoring
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StandardMonitoring()
        {
            return View();
        }

        public ActionResult MonitoringQueues()
        {
            return View();
        }

        public ActionResult MonitoringJobs()
        {
            return View();
        }

        public ActionResult MonitoringJobsChild()
        {
            return View();
        }
    }
}