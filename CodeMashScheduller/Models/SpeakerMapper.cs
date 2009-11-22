using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CodeMashScheduller.Models
{
    public class SpeakerMapper : MapperBase, ISpeakerMapper
    {
        public Speaker Create(XmlNode xmlSpeaker)
        {
            var speaker = new Speaker
                              {
                                  Biography = getNodeString(xmlSpeaker, "Biography"),
                                  BlogURL = getNodeString(xmlSpeaker, "BlogURL"),
                                  Name = getNodeString(xmlSpeaker, "Name"),
                                  TwitterHandle = getNodeString(xmlSpeaker, "TwitterHandle"),
                                  Sessions = getSessionUris(xmlSpeaker)
                              };

            return speaker;
        }

        private IEnumerable<string> getSessionUris(XmlNode xmlSpeaker)
        {
            var nodes = xmlSpeaker.SelectNodes("Sessions/SessionURI");
            if (nodes == null) return new List<string>();
            return (from XmlNode sessionUriNode in nodes select getNodeString(sessionUriNode,"SessionURI"));
        }
    }
}