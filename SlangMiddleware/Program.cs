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

// Reads the content of main.slang
var content = File.ReadAllText(sourceFile);

buildText(sb, sourceFilePath!, sourceFile);

var tempFile = createTempFile(sb);

await startCli(tempFile);

// After run remove file.
File.Delete(tempFile);

searchArguments(arguments, sb);


// Build Text
static void buildText(StringBuilder sb, string mainFolder, string sourceFile)
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

            buildText(sb, mainFolder, Path.Combine(mainFolder, $"{pseudoPath.Trim('"')}.slang"));
        }
        else
        {
            sb.AppendLine(line);
        }
    }

    if (sb.ToString().Contains("main"))
    {
        sb.AppendLine("main();");
    }
}

// Create Temp File
static string createTempFile(StringBuilder sb)
{
    if (!Directory.Exists(Resources.TEMP_FILES_PATH))
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

// Open Process of CLI
static async Task startCli(string tempFile)
{
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
}

// Search arguments
static void searchArguments(List<string> arguments, StringBuilder sb)
{
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
}