using System;
using System.Web.Mvc;
using CodeMashScheduller.Models;

namespace CodeMashScheduller.Controllers
{
    public class CodemashController : Controller
    {
        public ActionResult Selection(string id)
        {
            var schedulle = new SchedullerService(Server).GetSchedulle(id);
            ViewData["name"] = id;
            return View(schedulle);
        }

        public CalendarResult Calendar(string id)
        {
            var schedulle = new SchedullerService(Server).GetSchedulle(id);
            return new CalendarResult(schedulle);
        }
    }
}
