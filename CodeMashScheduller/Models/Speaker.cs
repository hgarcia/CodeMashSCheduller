using System.Collections.Generic;

namespace CodeMashScheduller.Models
{
    public class Speaker
    {
        public virtual string Name{ get; set;}
        public virtual string Biography { get; set; }
        public virtual IEnumerable<string> Sessions { get; set; }
        public virtual string TwitterHandle { get; set;}
        public virtual string BlogURL { get; set;}
    }
}