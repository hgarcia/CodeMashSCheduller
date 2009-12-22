using CodeMashScheduller.Models;
using NUnit.Framework;

namespace CodeMashScheduller.Tests
{
    [TestFixture]
    public class PrecompilerMapper_Specification
    {
        [Test]
        public void When_passing_an_xmlNode_Should_return_a_valid_Precompiler()
        {
            var nodes = new StubProxyReader().GetPrecompiler();
            var precompilerMapper = new PrecompilerMapper();
            var precompiler = precompilerMapper.Create(nodes[0]);

            Assert.That(precompiler, Is.AssignableTo(typeof(Precompiler)));
            Assert.That(precompiler.Title.Length, Is.GreaterThan(0));
        }

        [Test]
        public void When_passing_an_xml_node_Should_map_all_properties_an_elements_in_the_xml()
        {
            var nodes = new StubProxyReader().GetPrecompiler();
            var precompilerMapper = new PrecompilerMapper();
            var precompiler = precompilerMapper.Create(nodes[0]);

            Assert.That(precompiler.Title, Is.Not.Empty);
            Assert.That(precompiler.Abstract, Is.Not.Empty);
            Assert.That(precompiler.Start.HasValue, "Start time doesn't have a value");
            Assert.That(precompiler.Difficulty, Is.Not.Null);
            Assert.That(precompiler.Room, Is.Not.Null);
            Assert.That(precompiler.Technology, Is.Not.Null);
            Assert.That(precompiler.Track, Is.Not.Null);
            Assert.That(precompiler.SpeakerName, Is.Not.Null);
        }
    }
}