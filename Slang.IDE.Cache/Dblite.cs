using Slang.IDE.Cache.Interfaces;
using Slang.IDE.Cache.Queries;

namespace Slang.IDE.Cache
{
    public class Dblite : IDatabase
    {
        public void CreateModel()
        {
            BookmarkQueriesCollection.CreateTable();
        }
    }
}
