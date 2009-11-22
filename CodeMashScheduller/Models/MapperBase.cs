using System.Xml;

namespace CodeMashScheduller.Models
{
    public class MapperBase
    {
        protected string getNodeString(XmlNode parentXmlNode,string nodeName)
        {
            var singleNode = parentXmlNode.SelectSingleNode("" + nodeName);
            if (singleNode!= null) return singleNode.InnerText;
            return string.Empty;
        }
    }
}