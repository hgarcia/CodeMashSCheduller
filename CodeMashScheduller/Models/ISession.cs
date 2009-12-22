using System;

namespace CodeMashScheduller.Models
{
    public interface ISession
    {
        int Id { get; set; }
        string Title { get; set; }
        string Abstract { get; set; }
        DateTime? Start { get; set; }
        Levels Difficulty { get; set; }
        string SpeakerName { get; set; }
        string Room { get; set; }
        string Technology { get; set; }
        string Track { get; set; }
    }
}