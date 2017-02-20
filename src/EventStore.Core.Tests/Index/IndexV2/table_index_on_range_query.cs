using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index.IndexV2
{
    [TestFixture]
    public class table_index_on_range_query : IndexV1.table_index_on_range_query
    {
        public table_index_on_range_query()
        {
            _ptableVersion = PTableVersions.IndexV2;
        }
    }
}
