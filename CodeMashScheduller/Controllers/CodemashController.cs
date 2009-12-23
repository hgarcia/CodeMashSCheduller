using System.Web.Mvc;
using CodeMashScheduller.Models;

namespace CodeMashScheduller.Controllers
{
    public class CodemashController : Controller
    {
        public ActionResult Selection(string id)
        {
            var savedSessions = SavedSessions.FindAllByProperty("Name", id)[0];
            return View(savedSessions);
        }

    }
}
