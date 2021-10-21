using FluentAssertions;
using NUnit.Framework;
using ACL.Serialization.Xml;
using ACL.UnitTesting;
using System.Linq;
using System.Xml;

namespace ACL.Serialization.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private string SubItemName { get; set; } = "Sub-Item-1";
        private int ItemId { get; set; } = 1234;
        private int SubItemId { get; set; } = 42;

        [Test]
        public void XmlSerializationTest()
        {
            var obj = new GenericItem() { Id = ItemId };
            obj.SubItems.Add(new GenericSubItem(SubItemId, SubItemName));
            var xml = XmlConverter.Serialize(obj);
            xml.Should().Be(Properties.Resources.XmlSample);
        }

        [Test]
        public void XmlDeserializationTest()
        {
            var xml = Properties.Resources.XmlSample;
            var item = XmlConverter.Deserialize<GenericItem>(xml);
            item.Id.Should().Be(ItemId);
            item.SubItems.Should().NotBeNull();
            item.SubItems.Count.Should().BeGreaterThan(0);
            item.SubItems.First().Name.Should().Be(SubItemName);
            item.SubItems.First().Id.Should().Be(SubItemId);
        }
    }
}