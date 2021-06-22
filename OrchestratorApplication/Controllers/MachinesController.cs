using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrchestratorApplication.Models;
using OrchestratorApplication.Models.MachineModel;

namespace OrchestratorApplication.Controllers
{
    public class MachinesController : Controller
    {
        OrchestratorDBEntities1 db = new OrchestratorDBEntities1();

        public object ClientScript { get; private set; }

        public ActionResult Index()
        {
            return View(db.StandardMachines.ToList());
        }

        [HttpPost]
        public ActionResult SaveRecord(StandardMachine model)
        {
            try
            {
               
                    OrchestratorDBEntities1 db = new OrchestratorDBEntities1();

                    StandardMachine emp = new StandardMachine();
                    emp.Name = model.Name;
                    emp.Type = model.Type;
                    emp.Installed_version = model.Installed_version;

                    db.StandardMachines.Add(emp);
                    db.SaveChanges();

            }
            catch (Exception ex){
                string message = string.Format("Message: {0}\\n\\n", ex.Message);            
        }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult SaveRecord2(StandardMachine model)
        {
            try
            {

                OrchestratorDBEntities1 db = new OrchestratorDBEntities1();

                StandardMachine emp = new StandardMachine();
                emp.Name = model.Name;
                emp.Type = model.Type;
                emp.Installed_version = model.Installed_version;

                db.StandardMachines.Add(emp);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }
    }
}