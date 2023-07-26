﻿using IDE.Preferences;
using IDE.Properties;
using Newtonsoft.Json;

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
                ParentId = projectFile.Id,
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
            var jsonFile = JsonConvert.SerializeObject(projectFile, Formatting.Indented);
            File.WriteAllText(Path.Combine(projectFile.FilePath, $"{projectFile.Name}.slangproject"), jsonFile);
            Sessions.SlangProject = projectFile;


            SaveToRecent(projectFile);
        }

        public static void UpdateProject()
        {
            // Load Existing
            using var sw = new StreamWriter(Path.Combine(Sessions.SlangProject.FilePath, $"{Sessions.SlangProject.Name}.slangproject"));
            sw.WriteLine(JsonConvert.SerializeObject(Sessions.SlangProject, Formatting.Indented));
        }


        public static void LoadProject(string projectPath)
        {
            if (string.IsNullOrEmpty(projectPath))
            {
                throw new ArgumentNullException(nameof(projectPath), "You must provide a path");
            }

            // Find the slangproject
            if(!projectPath.EndsWith(".slangproject"))
            {
                throw new NullReferenceException("There is not Slang Project in this directory.");
            }

            using var streamReader = new StreamReader(projectPath);
            var project = JsonConvert.DeserializeObject<SlangProject>(streamReader.ReadToEnd());
            streamReader.Close();

            Sessions.SlangProject = project!;
        }

        private static void SaveToRecent(SlangProject slangProject)
        {
            var path = slangProject.FilePath;
            var recentProjectFilePath = Path.Combine(Settings.Default["FileFolder"].ToString(), Settings.Default["RecentFile"].ToString());

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(recentProjectFilePath))
            {
                File.WriteAllText(recentProjectFilePath, "[]");
            }

            using var streamReader = new StreamReader(recentProjectFilePath);
            var projects = JsonConvert.DeserializeObject<List<RecentProject>>(streamReader.ReadToEnd())??new List<RecentProject>();

            projects.Add(new RecentProject
            {
                Name = slangProject.Name,
                Path = slangProject.FilePath,
                CreatedOn = DateTime.Now
            });

            streamReader.Close();


            var jsonText = JsonConvert.SerializeObject(projects, Formatting.Indented);
            using var streamWriter = new StreamWriter(recentProjectFilePath);
            streamWriter.WriteLine(jsonText);
            streamWriter.Close();
        }
    }
}
