using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrchestratorApplication.Models;
using OrchestratorApplication.Models.AssetsModel;

namespace OrchestratorApplication.Controllers
{
    public class AssetsController : Controller
    {
        OrchestratorDBEntities10 db = new OrchestratorDBEntities10();

        public object ClientScript { get; private set; }

        public ActionResult Index()
        {
            return View(db.Assets.ToList());
        }

        [HttpPost]
        public ActionResult SaveRecord(Asset model)
        {
            try
            {

                OrchestratorDBEntities10 db = new OrchestratorDBEntities10();

                Asset emp = new Asset();
                emp.Name = model.Name;
                emp.Type = model.Type;
                emp.Value = model.Value;

                db.Assets.Add(emp);
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