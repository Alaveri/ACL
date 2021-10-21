using FluentAssertions;
using NUnit.Framework;
using ACL.Data.Test.Mocks;
using ACL.UnitTesting;

namespace ACL.Data.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DataSourceReaderTest()
        {
            var dataSource = new MockDataSource(new MockDataSourceReader(), new MockDataSourceWriter());
            var item = dataSource.RetrieveItem(42);
            item.Id.Should().Be(42);
        }

        [Test]
        public void DataSourceWriteTest()
        {
            var dataSource = new MockDataSource(new MockDataSourceReader(), new MockDataSourceWriter());
            var item = new GenericItem();
            var id = dataSource.StoreItem(item);
            id.Should().Be(1234);
        }
    }
}