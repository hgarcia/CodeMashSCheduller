using System.Xml;

namespace CodeMashScheduller.Models
{
    public interface ISessionMapper
    {
        Session Create(XmlNode session);
       // Session Update(XmlNode session);
    }
}