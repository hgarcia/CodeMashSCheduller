using System.Xml;

namespace CodeMashScheduller.Models
{
    public interface IRestProxyReader
    {
        XmlNodeList GetSessions();
        XmlNodeList GetSpeakers();
    }
}