using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrchestratorApplication.Models;
using OrchestratorApplication.Models.QueuesModel;

namespace OrchestratorApplication.Controllers
{
    public class QueuesController : Controller
    {
        OrchestratorDBEntities12 db = new OrchestratorDBEntities12();
        public ActionResult Index()
        {
            return View(db.Queues.ToList());
        }

        [HttpPost]
        public ActionResult SaveRecord(Queue model)
        {
            try
            {

                OrchestratorDBEntities12 db = new OrchestratorDBEntities12();

                Queue emp = new Queue();

                emp.Name = model.Name;
                emp.Description = model.Description;
                emp.Retries = model.Retries;

                db.Queues.Add(emp);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }


        public ActionResult ReviewRequest()
        {

            return View(db.ReviewRequests.ToList());
        }
    }
}