using CodeMashScheduller.Models;
using NUnit.Framework;
using System.Linq;

namespace CodeMashScheduller.Tests
{
    [TestFixture]
    public class SessionRepository_Specifications
    {
        [SetUp]
        public void setup()
        {
            MvcApplication.InitializeActiveRecord();
        }

        [Test]
        public void When_calling_method_all_Should_return_an_IEnumerable_of_sessions()
        {
            var sessionMapper = new SessionMapper();
            var restProxyReader = new StubProxyReader();
            var sessionsFactory = new SessionRepository(sessionMapper, restProxyReader);

            var sessions = sessionsFactory.All();

            Assert.That(sessions.Count(),Is.GreaterThan(0));
            var singleSession = sessions.ToList()[0];
            Assert.That(singleSession, Is.Not.Null);
            Assert.That(singleSession, Is.AssignableTo(typeof(Session)));
        }

        [Test]
        public void When_Calling_selected_sessions_Should_return_an_IEnumerable_of_just_those_sessions()
        {
            var sessionMapper = new SessionMapper();
            var restProxyReader = new StubProxyReader();
            var sessionsFactory = new SessionRepository(sessionMapper, restProxyReader);

            var sessions = sessionsFactory.FindById("20,21,58");

            Assert.That(sessions.Count(), Is.GreaterThan(0));
            var sessionList = sessions.OrderBy(s => s.Id).ToList();
            Assert.That(sessionList[0].Id, Is.EqualTo(20));
            Assert.That(sessionList[1].Id, Is.EqualTo(21));
            Assert.That(sessionList[2].Id, Is.EqualTo(58));
            
        }
    }
}