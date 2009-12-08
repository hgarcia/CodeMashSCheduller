using System;
using System.Xml;
using NHibernate.Criterion;

namespace CodeMashScheduller.Models
{
    public class SessionMapper : MapperBase, ISessionMapper
    {
        public Session Create(XmlNode xmlSession)
        {
            var session = SetSession(xmlSession, new Session());
            try
            {
                session.Create();
            }
            catch (Exception e)
            {  
                throw e;
            }
           
            return session;
        }

        private Session SetSession(XmlNode xmlSession, Session session)
        {
            session.Abstract = getNodeString(xmlSession, "Abstract");
            session.URI = getNodeString(xmlSession, "URI").Replace("/rest/sessions/", "");
            session.Start = getStart(xmlSession);
            session.Title = getNodeString(xmlSession, "Title");
            session.SpeakerName = getNodeString(xmlSession, "SpeakerName");
            session.SpeakerURI = getNodeString(xmlSession, "SpeakerURI");
            session.Difficulty = getLevel(getNodeString(xmlSession, "Difficulty"));
            session.Room = getNodeString(xmlSession, "Room");
            session.Technology = getNodeString(xmlSession, "Technology");
            session.Track = getNodeString(xmlSession, "Technology");
            return session;
        }

        public Session Update(XmlNode xmlSession)
        {
            var sessionToUpdate = Session.FindOne(new ICriterion[]
                                                      {
                                                          Restrictions.Eq("URI",
                                                                          getNodeString(
                                                                              xmlSession, "URI").
                                                                              Replace(
                                                                              "/rest/sessions/",
                                                                              ""))
                                                      });

            if (sessionToUpdate == null) return Create(xmlSession);
            SetSession(xmlSession, sessionToUpdate);
            sessionToUpdate.Update();
            return sessionToUpdate;
        }

        private DateTime? getStart(XmlNode xmlSession)
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