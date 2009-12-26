using System;
using System.Text;

namespace CodeMashScheduller.Models
{
    public class SavedSessions
    {
        public virtual int Id { get; set; }
        private string _name;

        public virtual string Name
        {
            get
            {
                if (String.IsNullOrEmpty(_name))
                    _name = RandomString();
                return _name;
            }
            set { _name = value; }
        }

        public virtual string Precompilers { get; set; }

        public virtual string Sessions { get; set; }

        private static string RandomString()
        {
            var builder = new StringBuilder();
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString().ToLower();
        }
    }
}