namespace IDE.Preferences
{
    public static class SystemPreferences
    {

        public readonly static IReadOnlyCollection<string> Keywords = new List<string>()
        {
            "fn", "null", "int" ,"string", "bool", "float", "double", "return", "if", "for", "foreach", "while", "do", "else", "var", "struct", "class"
        };

        public readonly static IReadOnlyCollection<string> DataTypes = new List<string>()
        {
            "int", "string", "bool", "float", "double"
        };

        public readonly static IReadOnlyCollection<string> SystemFunctions = new List<string>()
        {
            "printer", "first", "last", "rest", "push", "array", "randPick", "sort", "len", "atoi", "randInt"
        };

        public static List<string> UserDefineDataTypes = new List<string>();
        public static List<UserDefineFunction> UserDefineFunctions = new List<UserDefineFunction>();
    }

    public sealed class UserDefineFunction
    {
        public string Name { get; set; } = string.Empty;
        public int Line { get; set; } = 0;
        public int Column { get; set; } = 0;
        public Type[] Types { get; set; }
    }

}
