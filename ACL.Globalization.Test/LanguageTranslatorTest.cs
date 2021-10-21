using FluentAssertions;
using NUnit.Framework;
using ACL.Globalization.Development;
using System.Globalization;

namespace ACL.Globalization.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TranslateTest()
        {
            var translation = DevTranslator.Current.Translate("TestTranslationPhrase");
            translation.Should().Be("Translated Phrase");
        }
    }
}