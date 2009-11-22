using System.Linq;
using CodeMashScheduller.Models;
using NUnit.Framework;

namespace CodeMashScheduller.Tests
{
    [TestFixture]
    public class SpeakerMapper_Specifications
    {
        [Test]
        public void When_passing_an_xmlNode_Should_return_a_valid_Speaker()
        {
            var nodes = new StubProxyReader().GetSpeakers();
            ISpeakerMapper speakerMapper = new SpeakerMapper();
            Speaker speaker = speakerMapper.Create(nodes[0]);

            Assert.That(speaker, Is.AssignableTo(typeof(Speaker)));
            Assert.That(speaker.Sessions.Count(),Is.GreaterThan(0));
        }
    }
}