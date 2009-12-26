using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CodeMashScheduller.Models
{
    public class SessionRepository
    {
        private readonly ISessionMapper _sessionMapper;
        private readonly IRestProxyReader _restProxyReader;

        public SessionRepository(ISessionMapper sessionMapper, IRestProxyReader restProxyReader)
        {
            _sessionMapper = sessionMapper;
            _restProxyReader = restProxyReader;
        }

        public IEnumerable<Session> All()
        {
            var nodes = _restProxyReader.GetSessions();
            return (from XmlNode session in nodes select _sessionMapper.Create(session))
                .ToList()
                .OrderBy(s => s.Start)
                .OrderBy(s => s.Room);
        }

        public IEnumerable<Session> FindById(string sessionIds)
        {
            var idsArr = sessionIds.Replace(" ", string.Empty).Split(',');
            return All().Where(s => idsArr.Any(id => s.Id.ToString() == id));
        }
    }
}