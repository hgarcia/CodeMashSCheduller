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
           /* try
            {
                session.Create();
            }
            catch (Exception e)
            {  
                throw e;
            }*/
           
            return session;
        }

        private Session SetSession(XmlNode xmlSession, Session session)
        {
            session.Id = Convert.ToInt16(xmlSession.Attributes["Id"].Value);
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

    
    }
}