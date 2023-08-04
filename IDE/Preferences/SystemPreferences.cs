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
            "print", "get_date",
        };

        public static List<string> UserDefineDataTypes = new List<string>();
        public static List<UserDefineFunction> UserDefineFunctions = new List<UserDefineFunction>();


        //public static IReadOnlyDictionary<string, Color> SystemDataTypes { get; } = new Dictionary<string, Color>
        //{
        //    {"int", Color.FromArgb(64,155,252) },
        //    {"int64", Color.FromArgb(64,155,252) },
        //    {"float", Color.FromArgb(64,155,252) },
        //    {"bool", Color.FromArgb(64,155,252) },
        //    {"string", Color.FromArgb(64,155,252) },
        //    {"let", Color.FromArgb(64,155,252) },
        //    {"void", Color.FromArgb(64,155,252) }
        //};

        //public static IReadOnlyDictionary<string, Color> Keywords { get; } = new Dictionary<string, Color>
        //{
        //    { "print", Color.FromArgb(214,160,223) },
        //    { "read", Color.FromArgb(214,160,223) },
        //    { "if", Color.FromArgb(214,160,223) },
        //    { "else if", Color.FromArgb(214,160,223)},
        //    { "else", Color.FromArgb(214,160,223) },
        //    { "for" , Color.FromArgb(214,160,223) },
        //    { "in" , Color.FromArgb(214,160,223) },
        //};

        //public static IReadOnlyDictionary<string, Color> Directives { get; } = new Dictionary<string, Color>
        //{
        //    {"#add", Color.LightGray },
        //};
    }

    public sealed class UserDefineFunction
    {
        public string Name { get; set; } = string.Empty;
        public int Line { get; set; } = 0;
        public int Column { get; set; } = 0;
        public Type[] Types { get; set; }
    }

}
