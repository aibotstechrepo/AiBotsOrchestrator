using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrchestratorApplication.Models;
using OrchestratorApplication.Models.RobotsModel;
//using Environment = OrchestratorApplication.Models.RobotsModel.Environment;

namespace OrchestratorApplication.Controllers
{
    public class RobotsController : Controller
    {
        OrchestratorDBEntities13 db = new OrchestratorDBEntities13();
        public ActionResult Index()
        {
            return View(db.StandardRobots.ToList());
        }

        [HttpPost]
        public ActionResult SaveRecord1(StandardRobot model)
        {
            try
            {

               
                StandardRobot emp = new StandardRobot();
                emp.Name = model.Name;
                //emp.Machine = "Machine";
                emp.Machine = model.Machine;
                emp.Username = model.Username;
                emp.Password = model.Password;
                //emp.Type = "Standard";
                emp.Type = model.Type;
                emp.Environments = model.Environments;
                emp.Status = model.Status;

                db.StandardRobots.Add(emp);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult SaveRecord2(StandardRobot model)
        {
            try
            {

                

                StandardRobot emp = new StandardRobot();
                emp.Name = model.Name;
                emp.Machine = model.Machine;
                emp.Username = model.Username;
                emp.Password = model.Password;
                emp.Type = model.Type;
                emp.Environments = model.Environments;
                emp.Status = model.Status;

                db.StandardRobots.Add(emp);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }

        public ActionResult RobotsEnvironments()
        {
            return View(db.Environments.ToList());
        }

        [HttpPost]
        public ActionResult SaveRecord3(Models.RobotsModel.Environment model)
        {
            try
            {



                Models.RobotsModel.Environment emp = new Models.RobotsModel.Environment();
                emp.Name = model.Name;
                emp.Description = model.Description;

                db.Environments.Add(emp);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("RobotsEnvironments");

        }
    }
}