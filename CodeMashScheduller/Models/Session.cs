using System;

namespace CodeMashScheduller.Models
{
    public class Session : ISession
    {
        public virtual int Id{ get; set;}
        public virtual string URI { get; set;}
        public virtual string Title { get; set;}
        public virtual string Abstract { get; set;}
        public virtual DateTime? Start { get; set;}
        public virtual Levels Difficulty { get; set;}
        public virtual string SpeakerName { get; set;}
        public virtual string SpeakerURI { get; set; }
        public virtual string Room { get; set; }
        public virtual string Technology { get; set; }
        public virtual string Track { get; set; }
    }
}