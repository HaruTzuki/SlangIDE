using SlangMiddleware.Properties;
using System.Diagnostics;
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

buildTheFile(sb, sourceFilePath!, sourceFile);

if (content.Contains("main"))
{
    sb.AppendLine("main();");
}

var tempFile = createTempFile(sb);


var startInfo = new ProcessStartInfo();
startInfo.UseShellExecute = false;
startInfo.RedirectStandardOutput = true;
startInfo.RedirectStandardError = true;
startInfo.RedirectStandardInput = true;
startInfo.Arguments = tempFile;
startInfo.CreateNoWindow = true;
startInfo.FileName = Resources.SLANG_COMPILER_WIN;

var process = new Process();
process.StartInfo = startInfo;

process.OutputDataReceived += async (ss, ee) =>
{
    Console.WriteLine(ee.Data);
};

process.Start();
process.BeginOutputReadLine();
await process.WaitForExitAsync();

File.Delete(tempFile);

foreach (var arg in arguments)
{
    switch (arg)
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

static string createTempFile(StringBuilder sb)
{
    if(!Directory.Exists(Resources.TEMP_FILES_PATH))
    {
        Directory.CreateDirectory(Resources.TEMP_FILES_PATH);
    }

    var tempFilePath = Path.Combine(Resources.TEMP_FILES_PATH, $"{Guid.NewGuid():N}.slang");

    try
    {
        File.WriteAllText(tempFilePath, sb.ToString());
    }
    catch (IOException ex)
    {
        throw;
    }

    return tempFilePath;
}