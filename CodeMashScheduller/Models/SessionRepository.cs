using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

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
            return (from XmlNode session in nodes select _sessionMapper.Create(session)).ToList();
        }
    }
}