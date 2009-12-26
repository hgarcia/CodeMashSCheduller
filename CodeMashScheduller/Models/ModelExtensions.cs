using System;
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

        public static string ToiCalTime(this DateTime dateTime)
        {
            return dateTime.ToiCalTime(0);
        }

        public static string ToiCalTime(this DateTime dateTime, int timeZoneDifference)
        {
            return dateTime.AddHours(timeZoneDifference).ToString("yyyyMMdd") + "T" + dateTime.AddHours(timeZoneDifference).ToString("HHmmssZ"); 
        }
    }
}
