using System;
using System.Xml;

namespace CodeMashScheduller.Models
{
    public class PrecompilerMapper : MapperBase, IPrecompilerMapper
    {
        public Precompiler Create(XmlNode xmlPrecompiler)
        {
            var precompiler = SetPrecompiler(xmlPrecompiler, new Precompiler());
           /* try
            {
                precompiler.Create();
            }
            catch (Exception e)
            {
                throw e;
            }*/

            return precompiler;
        }

        private Precompiler SetPrecompiler(XmlNode xmlPrecompiler, Precompiler precompiler)
        {
            precompiler.Id = Convert.ToInt16(xmlPrecompiler.Attributes["Id"].Value);
            precompiler.Abstract = getNodeString(xmlPrecompiler, "Abstract");
            precompiler.Start = getStart(xmlPrecompiler);
            precompiler.Title = getNodeString(xmlPrecompiler, "Title");
            precompiler.SpeakerName = getNodeString(xmlPrecompiler, "SpeakerName");
            precompiler.Difficulty = getLevel(getNodeString(xmlPrecompiler, "Difficulty"));
            precompiler.Room = getNodeString(xmlPrecompiler, "Room");
            precompiler.Technology = getNodeString(xmlPrecompiler, "Technology");
            precompiler.Track = getNodeString(xmlPrecompiler, "Technology");
            return precompiler;
        }
    }
}