using System;
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

        protected DateTime? getStart(XmlNode xmlSession)
        {
            try
            {
                var dateTime = Convert.ToDateTime(getNodeString(xmlSession, "Start"));
                var minSql = new DateTime(1753, 1, 1);
                return dateTime < minSql ? minSql : dateTime;
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected Levels getLevel(string difficulty)
        {
            switch (difficulty.ToLower())
            {
                case "beginner":
                    return Levels.Beginner;
                case "intermediate":
                    return Levels.Intermediate;
                case "advanced":
                    return Levels.Advanced;
            }
            return Levels.Unknown;
        }
    }
}