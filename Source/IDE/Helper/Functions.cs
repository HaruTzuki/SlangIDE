﻿using IDE.Preferences;
using IDE.Properties;
using Newtonsoft.Json;
using Slang.IDE.Cache.Queries;
using Slang.IDE.Domain.Entities.IDE;
using System.Data;

namespace IDE.Helper
{
    public static class Functions
    {
        private static readonly string _recentPath = Settings.Default["FileFolder"].ToString();
        private static readonly string _recentFilePath = Path.Combine(_recentPath, Settings.Default["RecentFile"].ToString());


        #region Project
        public static void CreateProject(string path, string name, Templates templates)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!Directory.Exists(Path.Combine(path, name)))
            {
                Directory.CreateDirectory(Path.Combine(path, name));
            }

            var root = $"{name}";

            var projectFile = new SlangProject()
            {
                FilePath = $"{root}",
                FileType = Slang.IDE.Shared.Enumerations.TreeFileType.Solution,
                Id = Guid.NewGuid(),
                Name = $"{name}"
            };

            var sourceFolder = new SlangProjectFiles()
            {
                FilePath = $"{root}/src",
                FileType = Slang.IDE.Shared.Enumerations.TreeFileType.Folder,
                ParentId = projectFile.Id,
                Name = "src",
                Id = Guid.NewGuid()
            };

            var mainFile = new SlangProjectFiles()
            {
                FilePath = $"{sourceFolder.FilePath}/main.slang",
                FileType = Slang.IDE.Shared.Enumerations.TreeFileType.File,
                Name = "main.slang",
                Id = Guid.NewGuid(),
                ParentId = sourceFolder.Id
            };

            projectFile.Files.Add(sourceFolder);
            projectFile.Files.Add(mainFile);

            // Create Files And Folders
            foreach (var folders in projectFile.Files.Where(x => x.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.Folder))
            {
                if (!Directory.Exists(Path.Combine(path, folders.FilePath)))
                {
                    Directory.CreateDirectory(Path.Combine(path, folders.FilePath));
                }
            }

            foreach (var files in projectFile.Files.Where(x => x.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.File))
            {
                if (!File.Exists(Path.Combine(path, files.FilePath)))
                {
                    File.Create(Path.Combine(path, files.FilePath)).Close();
                }
            }

            // Write Default Code in main.slang

            using var mainSourceFile = new StreamWriter(Path.Combine(path, projectFile.Files.FirstOrDefault(x => x.Name == "main.slang")!.FilePath));
            mainSourceFile.WriteLine(templates.Code);
            mainSourceFile.Close();

            // Create Project File
            var jsonFile = JsonConvert.SerializeObject(projectFile, Formatting.Indented);
            File.WriteAllText(Path.Combine(path, projectFile.FilePath, $"{projectFile.Name}.slangproject"), jsonFile);
            Sessions.SlangProject = projectFile;
            Sessions.ProjectPath = path;

            SaveRecent(path, projectFile);
        }

        public static void UpdateProject()
        {
            // Load Existing
            using var sw = new StreamWriter(Path.Combine(Sessions.ProjectPath, Sessions.SlangProject.FilePath, $"{Sessions.SlangProject.Name}.slangproject"));
            sw.WriteLine(JsonConvert.SerializeObject(Sessions.SlangProject, Formatting.Indented));
        }

        public static void LoadProject(string projectPath)
        {
            if (string.IsNullOrEmpty(projectPath))
            {
                throw new ArgumentNullException(nameof(projectPath), "You must provide a path");
            }

            // Find the slangproject
            if (!projectPath.EndsWith(".slangproject"))
            {
                throw new NullReferenceException("There is not Slang Project in this directory.");
            }

            using var streamReader = new StreamReader(projectPath);
            var project = JsonConvert.DeserializeObject<SlangProject>(streamReader.ReadToEnd());
            streamReader.Close();

            Sessions.SlangProject = project!;
            Sessions.ProjectPath = Directory.GetParent(Directory.GetParent(projectPath).FullName).FullName + "\\";
        }

        #endregion

        #region Recent
        private static void SaveRecent(string actualPath, SlangProject slangProject)
        {
            ProjectQueriesCollection.Insert(slangProject.Id.ToString(), slangProject.Name, Path.Combine(actualPath, slangProject.FilePath, slangProject.Name + ".slangproject"));
        }

        public static void SaveRecent(Project project)
        {
            ProjectQueriesCollection.Insert(project.Id, project.Name, project.Path);
        }

        public static IEnumerable<Project> LoadRecent()
        {
            return ProjectQueriesCollection.FetchAll();
        }

        public static void UpdateRecendProject(Project project)
        {

            if (!ProjectQueriesCollection.Update(project.Id, project.Name))
                throw new ArgumentException();

        }
        #endregion

        #region Various Methods
        public static int Map(int value, int inMin, int inMax, int outMin, int outMax)
        {
            return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }

        public static Type ConvertToType(string source)
        {
            if (SystemPreferences.DataTypes.Contains(source))
            {
                return Type.GetType(source);
            }

            if (SystemPreferences.UserDefineDataTypes.Contains(source))
            {
                return Type.GetType(source);
            }

            return null;
        }
        #endregion


    }
}
