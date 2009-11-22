using System;

namespace CodeMashScheduller.Models
{
    public class Session
    {
        public virtual string URI { get; set;}
        public virtual string Title { get; set;}
        public virtual string Abstract { get; set;}
        public virtual DateTime? Start { get; set;}
        public virtual Levels Difficulty { get; set;}
        public virtual string SpeakerName { get; set;}
        public virtual string SpeakerURI { get; set; }
    }

}