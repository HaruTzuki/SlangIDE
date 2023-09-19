using System.Data;

namespace Slang.IDE.Cache
{
    public class Parameter
    {
        public string Name;
        public object Value;
        public DbType DbType;

        public Parameter() { }

        public Parameter(string name, object value, DbType dbType)
        {
            Name = name;
            Value = value;
            DbType = dbType;
        }
    }
}
