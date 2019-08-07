namespace API.ProjectGeneration
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            IVisualStudioSolution sln = CreateProject.VisualStudio("My Solution");

            sln.AddCsharpProject("Console Project")
               .UseConsole();

            sln.AddCsharpProject("Wpf Project")
               .UseWpf()
               .ConfigureProjectRoot(projectRoot =>
               {
                   projectRoot.AddFile("Techo")
                              .OfType(FileType.Cs);
               });

            FileSystemSnapshot render = sln.Render();

            foreach (FileSystemEntry fileSystemEntry in render.Entries)
            {
                Console.WriteLine("{0} {1}", fileSystemEntry.IsDirectory ? "DIR " : "FILE", fileSystemEntry.RelativePath);
            }
        }
    }
}