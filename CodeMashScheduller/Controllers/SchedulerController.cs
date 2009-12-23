using System;
using System.Web.Mvc;
using CodeMashScheduller.Models;
using System.Linq;

namespace CodeMashScheduller.Controllers
{
    public class SchedulerController : Controller
    {
        public ActionResult Index()
        {
            var uncache = Request.QueryString.ToString().Contains("uncache");
            var sessionsRepository = new SessionRepository(new SessionMapper(), new RestProxyReader(Server,uncache));
            var sessions = sessionsRepository.All();
            var precompilerRepository = new PrecompilerRepository(new PrecompilerMapper(), Server);
            var precompilers = precompilerRepository.All();

            var model = new SchedulleModel
                            {
                                Precompiler = precompilers,
                                Day1 = sessions.Where(s =>
                                                          {
                                                              var start = s.Start.GetValueOrDefault(DateTime.Now);
                                                              return start >= new DateTime(2010, 1, 14) &&
                                                                     start < new DateTime(2010, 1, 15);
                                                          }),
                                Day2 =
                                    sessions.Where(
                                    s => s.Start.GetValueOrDefault(DateTime.Now) >= new DateTime(2010, 1, 15))
                            };
            
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
            savedSessions.Create();
            var result = new JsonResult { Data = savedSessions.Name };
            return result;
        }
    }
}
