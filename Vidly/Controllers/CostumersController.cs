using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace Vidly.Controllers
{
    public class CostumersController : Controller
    {
        // GET: Costumers
        public ActionResult Costumers()
        {
            var costumers = new CostumersController();
            return View(costumers);
        }

        public ActionResult Costumer(int id)
        {
            return Content("id = " + id);
        }
    }
}