using CodeMashScheduller.Models;
using NUnit.Framework;

namespace CodeMashScheduller.Tests
{
    [TestFixture]
    public class SessionMapper_Specifications
    {
        [SetUp]
        public void setup()
        {
            MvcApplication.InitializeActiveRecord();
        }
        [Test]
        public void When_passing_an_xmlNode_Should_return_a_valid_Session()
        {
            var nodes = new StubProxyReader().GetSessions();
            var sessionMapper = new SessionMapper();
            var session = sessionMapper.Create(nodes[0]);

            Assert.That(session,Is.AssignableTo(typeof(Session)));
            Assert.That(session.Title.Length,Is.GreaterThan(0));

            session.Delete();
        }
    }
}