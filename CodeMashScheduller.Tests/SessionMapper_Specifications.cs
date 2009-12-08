using System.Diagnostics;
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

        [Test]
        public void When_passing_an_xml_node_Should_map_all_properties_an_elements_in_the_xml()
        {
            var nodes = new StubProxyReader().GetSessions();
            var sessionMapper = new SessionMapper();
            var session = sessionMapper.Create(nodes[0]);

            Assert.That(session.URI,Is.Not.Empty);
            Assert.That(session.Title,Is.Not.Empty);
            Assert.That(session.Abstract, Is.Not.Empty);
            Assert.That(session.Start.HasValue,"Start time doesn't have a value");
            Assert.That(session.Difficulty,Is.Not.Null);
            Assert.That(session.Room, Is.Not.Null);
            Assert.That(session.Technology, Is.Not.Null);
            Assert.That(session.Track, Is.Not.Null);
            Assert.That(session.SpeakerName,Is.Not.Null);
            Assert.That(session.SpeakerURI, Is.Not.Null);

            session.Delete();
         
        }
    }
}