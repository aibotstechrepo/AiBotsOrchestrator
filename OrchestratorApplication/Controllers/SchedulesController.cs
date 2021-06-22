using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrchestratorApplication.Models;
using OrchestratorApplication.Models.SchedulesModel;

namespace OrchestratorApplication.Controllers
{
    public class SchedulesController : Controller
    {
        OrchestratorDBEntities6 db = new OrchestratorDBEntities6();
        // GET: Schedules
        public ActionResult Index()
        {

            return View(db.Schedules.ToList());
        }
    }
}