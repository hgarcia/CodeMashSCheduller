using System;
using Castle.ActiveRecord;

namespace CodeMashScheduller.Models
{
    [ActiveRecord]
    public class Session : ActiveRecordBase<Session>
    {
        [PrimaryKey]
        public virtual int Id{ get; set;}
        [Property(Length = 255)]
        public virtual string URI { get; set;}
        [Property(Length = 255)]
        public virtual string Title { get; set;}
        [Property(Length = 3000)]
        public virtual string Abstract { get; set;}
        [Property]
        public virtual DateTime? Start { get; set;}
        [Property]
        public virtual Levels Difficulty { get; set;}
        [Property]
        public virtual string SpeakerName { get; set;}
        [Property]
        public virtual string SpeakerURI { get; set; }
    }

}