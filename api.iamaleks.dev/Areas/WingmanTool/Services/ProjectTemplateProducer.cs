namespace Api.Areas.WingmanTool.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using Api.Areas.WingmanTool.Models;

    using Microsoft.Extensions.FileProviders;

    public class ProjectTemplateProducer : IProjectTemplateProducer
    {
        private readonly IWebRootFileProvider _webRootFileProvider;

        private List<FileTreeEntry> _fileTreeEntries;

        private string _projectType;

        public ProjectTemplateProducer(IWebRootFileProvider webRootFileProvider)
        {
            _webRootFileProvider = webRootFileProvider;
        }

        public FileTreeTemplate ProduceTemplateFor(string projectType)
        {
            _fileTreeEntries = new List<FileTreeEntry>();
            _projectType = projectType;

            PopulateFileTreeEntries();

            return new FileTreeTemplate(_fileTreeEntries);
        }

        public async Task<string> RenderFile(string projectType, string projectName, string relativePath)
        {
            _projectType = projectType;

            return await RenderFile(projectName, relativePath);
        }

        private void PopulateFileTreeEntries(string relativePath = "")
        {
            string directoryPath = FindTemplatePath(relativePath);
            IDirectoryContents directoryContents = _webRootFileProvider.GetDirectoryContents(directoryPath);

            foreach (var fileSystemEntry in directoryContents)
            {
                string entryRelativePath = Path.Combine(relativePath, fileSystemEntry.Name);

                _fileTreeEntries.Add(new FileTreeEntry(entryRelativePath, fileSystemEntry.IsDirectory));

                if (fileSystemEntry.IsDirectory)
                {
                    PopulateFileTreeEntries(entryRelativePath);
                }
            }
        }

        private async Task<string> RenderFile(string projectName, string relativePath)
        {
            string fileTemplatePath = FindTemplatePath(relativePath);
            StringBuilder fileContents = new StringBuilder(await ReadFile(fileTemplatePath));

            fileContents = ReplaceProjectTokens(fileContents, projectName);
            fileContents = ReplaceGuidTokens(fileContents);

            return fileContents.ToString();
        }

        private string FindTemplatePath(string relativePath)
        {
            return Path.Combine("Templates", _projectType, relativePath);
        }

        private async Task<string> ReadFile(string relativeFilePath)
        {
            await using Stream readSteam = _webRootFileProvider.GetFileInfo(relativeFilePath).CreateReadStream();
            using StreamReader streamReader = new StreamReader(readSteam);

            return await streamReader.ReadToEndAsync();
        }

        private static StringBuilder ReplaceProjectTokens(StringBuilder fileContents, string projectName)
        {
            fileContents.Replace("{projectName}", projectName);
            fileContents.Replace("{projectNamespace}", Regex.Replace(projectName, @"\s+", "."));

            return fileContents;
        }

        private StringBuilder ReplaceGuidTokens(StringBuilder fileContents)
        {
            for (int guidIndex = 0; guidIndex < 5; ++guidIndex)
            {
                fileContents.Replace($"$guid{guidIndex}$", Guid.NewGuid().ToString().ToUpperInvariant());
            }

            return fileContents;
        }
    }
}