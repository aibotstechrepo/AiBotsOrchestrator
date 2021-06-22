using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrchestratorApplication.Models;
using OrchestratorApplication.Models.ProcessesModel;

namespace OrchestratorApplication.Controllers
{
    public class ProcessesController : Controller
    {
        OrchestratorDBEntities3 db = new OrchestratorDBEntities3();
        // GET: Processes
        public ActionResult Index()
        {
            return View(db.Processes.ToList());
        }

        [HttpPost]
        public ActionResult SaveRecord1(Process model)
        {
            try
            {

                OrchestratorDBEntities3 db = new OrchestratorDBEntities3();

                Process emp = new Process();
                emp.Name = model.Name;
                emp.Version = model.Version;
                emp.Environment = model.Environment;
                emp.Description = model.Description;
                

                db.Processes.Add(emp);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }

        public ActionResult Packages()
        {
            return View(db.Processes.ToList());
        }
    }
}