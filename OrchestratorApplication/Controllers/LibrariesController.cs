using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrchestratorApplication.Controllers
{
    public class LibrariesController : Controller
    {
        // GET: Libraries
        public ActionResult Index()
        {
            return View();
        }
    }
}