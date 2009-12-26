using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using CodeMashScheduller.Models;

namespace CodeMashScheduller.Controllers
{
    public class CalendarResult : ActionResult
    {
        private readonly SchedulleModel _schedulle;

        public CalendarResult(SchedulleModel schedulle)
        {
            _schedulle = schedulle;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Clear();
            context.HttpContext.Response.ContentType = "text/calendar";

            context.HttpContext.Response.Write("BEGIN:VCALENDAR\n");
            context.HttpContext.Response.Write("VERSION:2.0\n");
            context.HttpContext.Response.Write("PRODID:-//hacksw/handcal//NONSGML v1.0//EN\n");

            AddPrecompiler(context.HttpContext.Response, _schedulle.Precompiler);
            AddSessions(context.HttpContext.Response, _schedulle.Day1);
            AddSessions(context.HttpContext.Response, _schedulle.Day2);

            context.HttpContext.Response.Write("END:VCALENDAR\n");
        }

        private void AddPrecompiler(HttpResponseBase response, IEnumerable<Precompiler> sessions)
        {
            foreach (var session in sessions)
            {
                response.Write("BEGIN:VEVENT\n");
                response.Write("DTSTART:" + session.Start.Value.ToiCalTime(+5) + "\n");
                response.Write("SUMMARY:" + session.Title + " with " + session.SpeakerName + "\n");
                response.Write("DESCRIPTION:" + session.Abstract + "\n");
                response.Write("COMMENT: Technology: " + session.Technology + "\n");
                response.Write("COMMENT: Difficulty: " + session.Difficulty + "\n");
                response.Write("LOCATION:" + session.Room + "\n");
                response.Write("END:VEVENT\n");
            }
        }
        private void AddSessions(HttpResponseBase response, IEnumerable<Session> sessions)
        {
            foreach (var session in sessions)
            {
                response.Write("BEGIN:VEVENT\n");
                response.Write("DTSTART:" + session.Start.Value.ToiCalTime(+5) + "\n");
                response.Write("SUMMARY:" + session.Title + " with " + session.SpeakerName + "\n");
                response.Write("DESCRIPTION:" + session.Abstract + "\n");
                response.Write("COMMENT: Technology: " + session.Technology + "\n");
                response.Write("COMMENT: Difficulty: " + session.Difficulty + "\n");
                response.Write("LOCATION:" + session.Room + "\n");
                response.Write("END:VEVENT\n");
            }
        }
    }
}