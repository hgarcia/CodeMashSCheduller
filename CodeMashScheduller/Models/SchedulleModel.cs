using System.Collections.Generic;

namespace CodeMashScheduller.Models
{
    public class SchedulleModel
    {
        public IEnumerable<Precompiler> Precompiler { get; set; }
        public IEnumerable<Session> Day1 { get; set; }
        public IEnumerable<Session> Day2 { get; set; }
    }
}