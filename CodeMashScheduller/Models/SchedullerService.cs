using System;
using System.Linq;
using System.Web;

namespace CodeMashScheduller.Models
{
    public class SchedullerService
    {
        private SavedSessionsRepository savedSessionsRepository;
        private PrecompilerRepository precompilerRepository;
        private SessionRepository sessionRepository;

        public SchedullerService(HttpServerUtilityBase server)
        {
            savedSessionsRepository = new SavedSessionsRepository(server);    
            precompilerRepository = new PrecompilerRepository(new PrecompilerMapper(),server);
            sessionRepository = new SessionRepository(new SessionMapper(), new RestProxyReader(server,false));
        }

        public SchedulleModel GetSchedulle(string id)
        {
            var savedSessions = savedSessionsRepository.FindById(id);
            var sessions =  sessionRepository.FindById(savedSessions.Sessions);

            return new SchedulleModel
                       {
                           Precompiler = precompilerRepository.FindById(savedSessions.Precompilers),
                           Day1 = sessions.Where(s =>
                                                     {
                                                         var start = s.Start.GetValueOrDefault(DateTime.Now);
                                                         return start >= new DateTime(2010, 1, 14) &&
                                                                start < new DateTime(2010, 1, 15);
                                                     }),
                           Day2 = sessions.Where(
                               s => s.Start.GetValueOrDefault(DateTime.Now) >= new DateTime(2010, 1, 15))
                       };
        }

        public SchedulleModel GetAllSessions()
        {
            var sessions = sessionRepository.All();
            var precompilers = precompilerRepository.All();

            return new SchedulleModel
            {
                Precompiler = precompilers,
                Day1 = sessions.Where(s =>
                {
                    var start = s.Start.GetValueOrDefault(DateTime.Now);
                    return start >= new DateTime(2010, 1, 14) &&
                           start < new DateTime(2010, 1, 15);
                }),
                Day2 =
                    sessions.Where(
                    s => s.Start.GetValueOrDefault(DateTime.Now) >= new DateTime(2010, 1, 15))
            };
        }
    }
}