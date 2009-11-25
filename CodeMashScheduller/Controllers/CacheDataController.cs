using System.Web.Mvc;

namespace CodeMashScheduller.Controllers
{
    public class CacheDataController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult ReCache()
        {
            var result = new JsonResult();
            result.Data = "OK";
            return result;
        }
    }
}
