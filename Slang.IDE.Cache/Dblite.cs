using Dapper;
using Slang.IDE.Cache.Interfaces;
using Slang.IDE.Cache.Properties;
using Slang.IDE.Cache.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
