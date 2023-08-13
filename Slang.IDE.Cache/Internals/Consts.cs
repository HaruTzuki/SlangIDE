using Slang.IDE.Cache.Properties;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Slang.IDE.Cache.Internals
{
    internal static class Consts
    {
        internal static string ConnectionString = $"Data Source={Resources.CacheFolder}/{Resources.CacheFile};Version=3;";
    }
}
