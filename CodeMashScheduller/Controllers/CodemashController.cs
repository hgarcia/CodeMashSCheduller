using System;
using System.Linq;
using System.Web.Mvc;
using CodeMashScheduller.Models;

namespace CodeMashScheduller.Controllers
{
    public class CodemashController : Controller
    {
        public ActionResult Selection(string id)
        {
            var savedSessions = SavedSessions.FindAllByProperty("Name", id)[0];
            var sessions =  new SessionRepository(new SessionMapper(), new RestProxyReader(Server, false))
                    .FindById(savedSessions.Sessions);

            var schedulle = new SchedulleModel
                                {
                                    Precompiler =
                                        new PrecompilerRepository(new PrecompilerMapper(), Server).FindById(
                                        savedSessions.Precompilers),
                                    Day1 = sessions.Where(s =>
                                                              {
                                                                  var start = s.Start.GetValueOrDefault(DateTime.Now);
                                                                  return start >= new DateTime(2010, 1, 14) &&
                                                                         start < new DateTime(2010, 1, 15);
                                                              }),
                                    Day2 = sessions.Where(
                                        s => s.Start.GetValueOrDefault(DateTime.Now) >= new DateTime(2010, 1, 15))
                                };


            return View(schedulle);
        }

    }
}
