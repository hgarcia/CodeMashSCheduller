using System.Web.Mvc;
using CodeMashScheduller.Models;

namespace CodeMashScheduller.Controllers
{
    public class SchedulerController : Controller
    {
        public ActionResult Index()
        {
            var model = new SchedullerService(Server).GetAllSessions();
            return View(model);
        }


        [AcceptVerbs("POST")]
        public JsonResult Save()
        {
            var precompilers = Request.Form["precompiler"];
            var sessions = Request.Form["session"];
            var savedSessions = new SavedSessions();

            if (precompilers != null || sessions != null)
            {
                savedSessions.Precompilers = precompilers;
                savedSessions.Sessions = sessions;
            }

            new SavedSessionsRepository(Server).Save(savedSessions);
            var result = new JsonResult { Data = savedSessions.Name };
            return result;
        }
    }
}
