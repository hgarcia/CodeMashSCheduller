using System.IO;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace CodeMashScheduller.Models
{
    public class SavedSessionsRepository
    {
        private HttpServerUtilityBase _server;

        public SavedSessionsRepository(HttpServerUtilityBase server)
        {
            _server = server;
        }

        public SavedSessions FindById(string name)
        {
            var savedSessionPath = GetSavedSessionPath(name);
            var deserializer = new XmlSerializer(typeof(SavedSessions));
            using (var reader = new StreamReader(savedSessionPath))
            {
                return (SavedSessions)deserializer.Deserialize(reader);
            }   
        }

        public void Save(SavedSessions savedSessions)
        {
            var savedSessionPath = GetSavedSessionPath(savedSessions.Name);
            var serializer =  new XmlSerializer(typeof(SavedSessions));
            using (var textWriter = new StreamWriter(savedSessionPath))
            {
                serializer.Serialize(textWriter, savedSessions);
            }
        }

        private string GetSavedSessionPath(string name)
        {
            return _server.MapPath(string.Format("~/Content/{0}.xml", name));
        }
    }
}