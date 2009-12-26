using System;

namespace CodeMashScheduller.Models
{
    public class Precompiler : ISession
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Abstract { get; set; }
        public virtual DateTime? Start { get; set; }
        public virtual Levels Difficulty { get; set; }
        public virtual string SpeakerName { get; set; }
        public virtual string Room { get; set; }
        public virtual string Technology { get; set; }
        public virtual string Track { get; set; }
    }
}