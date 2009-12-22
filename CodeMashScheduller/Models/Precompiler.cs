using System;
using Castle.ActiveRecord;

namespace CodeMashScheduller.Models
{
    public class Precompiler : ISession
    {
        [PrimaryKey]
        public virtual int Id { get; set; }
        [Property(Length = 255)]
        public virtual string Title { get; set; }
        [Property(Length = 3000)]
        public virtual string Abstract { get; set; }
        [Property]
        public virtual DateTime? Start { get; set; }
        [Property]
        public virtual Levels Difficulty { get; set; }
        [Property]
        public virtual string SpeakerName { get; set; }
        [Property]
        public virtual string Room { get; set; }
        [Property]
        public virtual string Technology { get; set; }
        [Property]
        public virtual string Track { get; set; }
    }
}