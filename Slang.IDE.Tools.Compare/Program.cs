using Slang.IDE.Shared.Extensions;
using static System.Console;

if (!args.Any())
    throw new ArgumentException("There is not available call without arguments.");

if (args[0].IsIn(new string[] { "-h", "-help", "--help", "--h" }))
{
    ShowHelp();
    return;
}

if (args.Contains("-source") && args.Contains("-to") && args.Length == 4)
{
    var firstFileText = File.ReadAllText(args[1]);
    var secondFileText = File.ReadAllText(args[3]);

    CompareText(firstFileText, secondFileText);
}

void CompareText(string firstFile, string secondFile)
{
    // Split into lines
    var firstFileLines = firstFile.Split("\n",StringSplitOptions.RemoveEmptyEntries);
    var secondFileLines = secondFile.Split("\n", StringSplitOptions.RemoveEmptyEntries);

    for(var line = 0; line < firstFileLines.Length; line++)
    {
        try
        {
            if (firstFileLines[line].Contains(secondFileLines[line], StringComparison.InvariantCultureIgnoreCase))
            {
                WriteLine($"Line:{line}|NOCHANGES");
            }
            else
            {
                WriteLine($"Line:{line}|NEW");
            }
        }
        catch (Exception)
        {
            WriteLine($"Line:{line}|NEWLINE");
            continue;
        }
    } 
    

}

void ShowHelp()
{
    WriteLine("In order to compare two files you have to provide this:");
    WriteLine("slangcompare -source {path} -to {path}");
}