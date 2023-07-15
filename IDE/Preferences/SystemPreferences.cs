namespace IDE.Preferences
{
    public sealed class SystemPreferences
    {
        public static IReadOnlyDictionary<string, Color> SystemDataTypes { get; } = new Dictionary<string, Color>
        {
            {"int", Color.FromArgb(64,155,252) },
            {"int64", Color.FromArgb(64,155,252) },
            {"float", Color.FromArgb(64,155,252) },
            {"bool", Color.FromArgb(64,155,252) },
            {"string", Color.FromArgb(64,155,252) },
            {"let", Color.FromArgb(64,155,252) },
            {"void", Color.FromArgb(64,155,252) }
        };

        public static IReadOnlyDictionary<string, Color> Keywords { get; } = new Dictionary<string, Color>
        {
            { "print", Color.FromArgb(214,160,223) },
            { "read", Color.FromArgb(214,160,223) },
            { "if", Color.FromArgb(214,160,223) },
            { "else if", Color.FromArgb(214,160,223)},
            { "else", Color.FromArgb(214,160,223) },
            { "for" , Color.FromArgb(214,160,223) },
            { "in" , Color.FromArgb(214,160,223) },
        };

        public static IReadOnlyDictionary<string, Color> Directives { get; } = new Dictionary<string, Color>
        {
            {"#add", Color.LightGray },
        };

        

    }
}
