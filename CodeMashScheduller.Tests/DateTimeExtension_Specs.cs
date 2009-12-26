using System;
using CodeMashScheduller.Models;
using NUnit.Framework;

namespace CodeMashScheduller.Tests
{
    [TestFixture]
    public class DateTimeExtension_Specs
    {
        [Test]
        public void When_Using_Format_to_serialize_Should_Use_yyyymmssTHHMMSSZ()
        {
            var date = new DateTime(2009, 10, 11, 23, 14, 56);

            var result = date.ToiCalTime(+5);
            var control = "20091012T041456Z";

            Assert.That(result,Is.EqualTo(control));
        }
    }
}