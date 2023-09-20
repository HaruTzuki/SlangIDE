using Slang.IDE.Cache.Interfaces;
using Slang.IDE.Cache.Internals;
using Slang.IDE.Cache.Properties;
using Slang.IDE.Cache.Queries;
using System;
using System.IO;

namespace Slang.IDE.Cache
{
    public class Dblite : IDatabase
    {
        public void CreateModel()
        {
            // Create Folder
            InitialiseProperties();

            ProjectQueriesCollection.CreateTable();
            BookmarkQueriesCollection.CreateTable();
        }

        private void InitialiseProperties()
        {
            if(!Directory.Exists(Resources.CacheFolder))
            {
                Directory.CreateDirectory(Resources.CacheFolder);
            }
        }
    }
}
