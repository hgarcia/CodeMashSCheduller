using System.Web.Mvc;
using CodeMashScheduller.Models;

namespace CodeMashScheduller.Controllers
{
    public class SchedullerController : Controller
    {
        public ActionResult Index()
        {
            var uncache = Request.QueryString.ToString().Contains("uncache");
            var sessionsRepository = new SessionRepository(new SessionMapper(), new RestProxyReader(Server,uncache));
            var sessions = sessionsRepository.All();
            return View(sessions);
        }
    }
}
