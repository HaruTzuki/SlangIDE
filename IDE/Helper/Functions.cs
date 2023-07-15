using IDE.Preferences;
using IDE.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Helper
{
    public static class Functions
    {
        public static void CreateProject(string path, string name, Templates templates)
        {
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if(!Directory.Exists(Path.Combine(path, name)))
            {
                Directory.CreateDirectory(Path.Combine(path,name));
            }

            var projectFile = new SlangProject()
            {
                FilePath = Path.Combine(path, name),
                FileType = Slang.IDE.Shared.Enumerations.TreeFileType.Solution,
                Id = Guid.NewGuid(),
                Name = $"{name}"
            };

            var sourceFolder = new SlangProjectFiles()
            {
                FilePath = Path.Combine(path, name, "src"),
                FileType = Slang.IDE.Shared.Enumerations.TreeFileType.Folder,
                Name = "src",
                Id = Guid.NewGuid()
            };

            var mainFile = new SlangProjectFiles()
            {
                FilePath = Path.Combine(sourceFolder.FilePath, "main.slang"),
                FileType = Slang.IDE.Shared.Enumerations.TreeFileType.File,
                Name = "main.slang",
                Id = Guid.NewGuid(),
                ParentId = sourceFolder.Id
            };

            projectFile.Files.Add(sourceFolder);
            projectFile.Files.Add(mainFile);

            // Create Files And Folders
            foreach(var folders in projectFile.Files.Where(x=>x.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.Folder))
            {
                if(!Directory.Exists(folders.FilePath))
                {
                    Directory.CreateDirectory(folders.FilePath);
                }
            }

            foreach(var files in projectFile.Files.Where(x=>x.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.File))
            {
                if(!File.Exists(files.FilePath))
                {
                    File.Create(files.FilePath).Close();
                }
            }

            // Write Default Code in main.slang

            using var mainSourceFile = new StreamWriter(projectFile.Files.FirstOrDefault(x => x.Name == "main.slang")!.FilePath);
            mainSourceFile.WriteLine(templates.Code);
            mainSourceFile.Close();

            // Create Project File
            var jsonFile = JsonConvert.SerializeObject(projectFile);
            File.WriteAllText(Path.Combine(projectFile.FilePath, $"{projectFile.Name}.slangproject"), jsonFile);
            Sessions.SlangProject = projectFile;


            SaveToRecent(projectFile);
        }

        public static void LoadProject(string projectPath)
        {
            if (string.IsNullOrEmpty(projectPath))
            {
                throw new ArgumentNullException(nameof(projectPath), "You must provide a path");
            }

            // Find the slangproject
            var files = Directory.GetFiles(projectPath, "*.slangproject");

            if(files?.Length <= 0)
            {
                throw new NullReferenceException("There is not Slang Project in this directory.");
            }

            using var streamReader = new StreamReader(files!.First());
            var project = JsonConvert.DeserializeObject<SlangProject>(streamReader.ReadToEnd());
            streamReader.Close();

            Sessions.SlangProject = project!;
        }

        private static void SaveToRecent(SlangProject slangProject)
        {
            var path = Settings.Default["FileFolder"].ToString();
            var filePath = Path.Combine(path, Settings.Default["RecentFile"].ToString());

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }

            using var streamReader = new StreamReader(filePath);
            var projects = JsonConvert.DeserializeObject<List<RecentProject>>(streamReader.ReadToEnd())??new List<RecentProject>();

            projects.Add(new RecentProject
            {
                Name = slangProject.Name,
                Path = slangProject.FilePath,
                CreatedOn = DateTime.Now
            });

            streamReader.Close();


            var jsonText = JsonConvert.SerializeObject(projects);
            using var streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine(jsonText);
            streamWriter.Close();
        }
    }
}
