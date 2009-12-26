using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace CodeMashScheduller.Models
{
    public class PrecompilerRepository
    {
        private readonly IPrecompilerMapper _precompilerMapper;
        private HttpServerUtilityBase _server;

        public PrecompilerRepository(IPrecompilerMapper precompilerMapper, HttpServerUtilityBase server)
        {
            _precompilerMapper = precompilerMapper;
            _server = server;
        }

        public IEnumerable<Precompiler> All()
        {
            var document = new XmlDocument();
            var docUrl = _server.MapPath("~/Content/precompiler.xml");
            document.Load(docUrl);

            var nodes = document.SelectNodes("/Precompilers/Precompiler");;
            return (from XmlNode precompiler in nodes select _precompilerMapper.Create(precompiler))
                .ToList()
                .OrderBy(p => p.Start)
                .OrderBy(p => p.Room);
        }

        public IEnumerable<Precompiler> FindById(string precompilersIds)
        {
            var idsArr = precompilersIds.Replace(" ", string.Empty).Split(',');
            return All().Where(s => idsArr.Any(id => s.Id.ToString() == id));
        }
    }
}