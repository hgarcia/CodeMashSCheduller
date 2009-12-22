using System.Xml;
using CodeMashScheduller.Models;

namespace CodeMashScheduller.Tests
{
    public class StubProxyReader : IRestProxyReader
    {
        public XmlNodeList GetSessions()
        {
            var document = new XmlDocument();
            document.Load("sessions.xml");
            return document.SelectNodes("/Sessions/Session");;
        }

        public XmlNodeList GetSpeakers()
        {
            var document = new XmlDocument();
            document.Load("speakers.xml");
            return document.SelectNodes("/Speakers/Speaker"); ;           
        }

        public XmlNodeList GetPrecompiler()
        {
            var document = new XmlDocument();
            document.Load("precompiler.xml");
            return document.SelectNodes("/Precompilers/Precompiler");;
        }
    }
}