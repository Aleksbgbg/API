namespace API.ProjectGeneration
{
    using System;

    using API.ProjectGeneration.FileSystem;
    using API.ProjectGeneration.Models;
    using API.ProjectGeneration.Projects;
    using API.ProjectGeneration.Projects.VisualStudio;
    using API.ProjectGeneration.Serialization;

    public static class Program
    {
        public static void Main()
        {
            IVisualStudioSolution sln = CreateProject.VisualStudio("My Solution");

            sln.AddCsharpProject("Console Project").UseConsole();

            sln.AddCsharpProject("Wpf Project")
               .UseWpf()
               .ConfigureProjectRoot(projectRoot =>
               {
                   projectRoot.AddFile("Techo").OfType(FileType.Cs);
               });

            string slns = new SolutionFileRenderer(new SolutionTemplateReader()).Render(new Solution(new[]
            {
                new Project("Techo", ProjectType.Csharp),
                new Project("CppProj", ProjectType.Cpp)
            }));

            FileSystemSnapshot render = sln.Render();

            foreach (FileSystemEntry fileSystemEntry in render.Entries)
            {
                Console.WriteLine("{0} {1}", fileSystemEntry.IsDirectory ? "DIR " : "FILE", fileSystemEntry.RelativePath);
            }

            Console.WriteLine(slns);
        }
    }
}