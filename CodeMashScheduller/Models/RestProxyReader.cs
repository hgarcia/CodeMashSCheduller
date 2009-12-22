using System;
using System.IO;
using System.Net;
using System.Web;
using System.Xml;

namespace CodeMashScheduller.Models
{
    public class RestProxyReader : IRestProxyReader
    {
        private readonly HttpServerUtilityBase _server;
        private readonly bool _uncache;
        private const string REST_URI_BASE = "http://codemash.org/rest/";

        public RestProxyReader(HttpServerUtilityBase server, bool uncache)
        {
            _server = server;
            _uncache = uncache;
        }

        public XmlNodeList GetSessions()
        {
            return getNodeList("sessions").SelectNodes("/Sessions/Session");
        }

        private XmlDocument getNodeList(string resourceName)
        {
            var xml = getFromDisk(resourceName);
            if(xml != null) return xml;
            xml = getFromWeb(resourceName);
            xml.Save(_server.MapPath("~/Content/" + resourceName + ".xml"));
            return xml;
        }

        private XmlDocument getFromDisk(string resourceName)
        {
            if(_uncache) return null;
            var path = _server.MapPath("~/Content/" + resourceName + ".xml");
            if (File.Exists(path))// && File.GetLastWriteTime(path).Date >= DateTime.Now.Date)
            {
                var xml = new XmlDocument();
                xml.Load(path);
                return xml;
            }
            return null;
        }

        private XmlDocument getFromWeb(string resourceName)
        {
            var request = WebRequest.Create(REST_URI_BASE + resourceName) as HttpWebRequest;
            using (var response = request.GetResponse() as HttpWebResponse)  
            {  
                var xml = new XmlDocument();
                xml.Load(response.GetResponseStream());
                return xml;
            }
        }

        public XmlNodeList GetSpeakers()
        {
            return getNodeList("speakers").SelectNodes("/Speakers/Speaker");
        }
    }
}