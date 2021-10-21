using ACL.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACL.Data.Test.Mocks
{
    public class MockDataSource : DataSource<MockDataSourceReader, MockDataSourceWriter>
    {
        public GenericItem RetrieveItem(int id)
        {
            return Reader.GetGenericItem(id);
        }

        public int StoreItem(GenericItem item)
        {
            return Writer.SetGenericItem(item);
        }

        public MockDataSource(MockDataSourceReader reader, MockDataSourceWriter writer): 
            base(reader, writer)
        {
        }
    }
}
