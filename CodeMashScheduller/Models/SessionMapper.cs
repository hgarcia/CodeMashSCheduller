using System;
using System.Xml;

namespace CodeMashScheduller.Models
{
    public class SessionMapper : MapperBase, ISessionMapper
    {
        public Session Create(XmlNode xmlSession)
        {
            var session = new Session
                              {
                                  Abstract = getNodeString(xmlSession, "Abstract"),
                                  URI = getNodeString(xmlSession, "URI").Replace("/rest/sessions/",""),
                                  Start = getStart(xmlSession),
                                  Title = getNodeString(xmlSession, "Title"),
                                  SpeakerName = getNodeString(xmlSession, "SpeakerName"),
                                  SpeakerURI = getNodeString(xmlSession, "SpeakerURI"),
                                  Difficulty = getLevel(getNodeString(xmlSession, "Difficulty"))
                              };

            return session;
        }

        private DateTime? getStart(XmlNode xmlSession)
        {
            try
            {
                return Convert.ToDateTime(getNodeString(xmlSession, "Start"));
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Levels getLevel(string difficulty)
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