using System.Web;

namespace CodeMashScheduller.Models
{
    public static class ModelExtensions
    {
        public static string Encode(this string value)
        {
            return string.IsNullOrEmpty(value) ? string.Empty 
                : HttpUtility.HtmlEncode(value);
        }
    }
}
