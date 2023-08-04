using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

if (args.Length < 0)
{
    Console.WriteLine("You must provide the path of the .slang file which has the main function");
}

var sourceFile = args[0];
var sourceFilePath = Path.GetDirectoryName(sourceFile);

// Gets all other arguments
var arguments = args.ToList();
arguments.RemoveAt(0);

var sb = new StringBuilder();

// Check if this is startup file

using var streamReader = new StreamReader(sourceFile);
var content = streamReader.ReadToEnd();
streamReader.Close();

if(!content.Contains("main"))
{
    Console.WriteLine("You must provide the path of the .slang file which has the main function");
}



buildTheFile(sb, sourceFilePath, sourceFile);

sb.AppendLine("main();");


var startInfo = new ProcessStartInfo();
startInfo.UseShellExecute = false;
startInfo.RedirectStandardOutput = true;
startInfo.RedirectStandardError = true;
startInfo.RedirectStandardInput = true;
startInfo.Arguments = "10 0";
startInfo.CreateNoWindow = true;
startInfo.FileName = "C:\\Users\\SYCADA_USER\\Downloads\\main.exe";

var process = new Process();
process.StartInfo = startInfo;
process.OutputDataReceived += async (ss, ee) =>
{
    Console.WriteLine(ee.Data);
};

process.Start();
process.BeginOutputReadLine();
await process.WaitForExitAsync();

foreach (var arg in arguments)
{
    switch(arg)
    {
        case "-s": // Show the combine code;
            Console.WriteLine(sb.ToString());
            break;
        default:
            break;
    }
}




static void buildTheFile(StringBuilder sb, string mainFolder, string sourceFile)
{
    var line = string.Empty;
    using var sr = new StreamReader(sourceFile);

    while ((line = sr.ReadLine()) != null)
    {
        if (line.StartsWith("#add", StringComparison.Ordinal))
        {
            // It means you have other function file.
            var pseudoPath = (from Match match in Regex.Matches(line, "\"([^\"]*)\"")
                             select match.ToString()).First();

            buildTheFile(sb, mainFolder, Path.Combine(mainFolder, $"{pseudoPath.Trim('"')}.slang"));
        }
        else
        {
            sb.AppendLine(line);
        }

    }
}


