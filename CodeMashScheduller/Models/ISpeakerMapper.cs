using System.Xml;

namespace CodeMashScheduller.Models
{
    public interface ISpeakerMapper
    {
        Speaker Create(XmlNode xmlSpeaker);
    }
}