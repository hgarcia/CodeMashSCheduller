using System.Xml;

namespace CodeMashScheduller.Models
{
    public interface IPrecompilerMapper
    {
        Precompiler Create(XmlNode xmlPrecompiler);
    }
}