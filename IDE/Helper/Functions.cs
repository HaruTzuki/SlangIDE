using IDE.Preferences;
using IDE.Properties;
using Newtonsoft.Json;
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

            SaveToRecent(path, projectFile);
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
        private static void SaveToRecent(string actualPath, SlangProject slangProject)
        {
            if (!Directory.Exists(_recentPath))
            {
                Directory.CreateDirectory(_recentPath);
            }

            if (!File.Exists(_recentFilePath))
            {
                File.WriteAllText(_recentFilePath, "[]");
            }

            using var streamReader = new StreamReader(_recentFilePath);
            var projects = JsonConvert.DeserializeObject<List<RecentProject>>(streamReader.ReadToEnd()) ?? new List<RecentProject>();

            projects.Add(new RecentProject
            {
                Name = slangProject.Name,
                Path = Path.Combine(actualPath, slangProject.FilePath, slangProject.Name + ".slangproject"),
                Date = DateTime.Now
            });

            streamReader.Close();

            SaveRecent(projects);
        }

        public static void SaveRecent(IEnumerable<RecentProject> recentProjects)
        {
            var jsonText = JsonConvert.SerializeObject(recentProjects, Formatting.Indented);
            using var streamWriter = new StreamWriter(_recentFilePath);
            streamWriter.WriteLine(jsonText);
            streamWriter.Close();
        }

        public static IEnumerable<RecentProject> LoadRecent()
        {

            if (!Directory.Exists(_recentPath))
            {
                Directory.CreateDirectory(_recentPath);
            }

            if (!File.Exists(_recentFilePath))
            {
                File.WriteAllText(_recentFilePath, "[]");
            }

            using var streamReader = new StreamReader(_recentFilePath);
            return JsonConvert.DeserializeObject<IEnumerable<RecentProject>>(streamReader.ReadToEnd()) ?? Enumerable.Empty<RecentProject>();
        }

        public static void UpdateRecendProject(RecentProject project)
        {
            var recentProjects = LoadRecent();

            if (recentProjects.Any(x => x.Name == project.Name && x.Path == project.Path))
            {
                recentProjects.First(x => x.Name == project.Name && x.Path == project.Path).Date = DateTime.Now;
            }

            SaveRecent(recentProjects);
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
