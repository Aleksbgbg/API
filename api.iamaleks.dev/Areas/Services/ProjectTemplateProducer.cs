namespace Api.Areas.Services
{
    using System.Collections.Generic;
    using System.IO;

    using Api.Areas.WingmanTool.Models;

    using Microsoft.Extensions.FileProviders;

    public class ProjectTemplateProducer : IProjectTemplateProducer
    {
        private readonly IWebRootFileProvider _webRootFileProvider;

        private List<FileTreeEntry> _fileTreeEntries;

        private string _projectType;

        private string _projectName;

        public ProjectTemplateProducer(IWebRootFileProvider webRootFileProvider)
        {
            _webRootFileProvider = webRootFileProvider;
        }

        public FileTreeTemplate ProduceTemplateFor(string projectType, string projectName)
        {
            _fileTreeEntries = new List<FileTreeEntry>();
            _projectType = projectType;
            _projectName = projectName;

            PopulateFileTreeEntries();

            return new FileTreeTemplate(_fileTreeEntries);
        }

        private void PopulateFileTreeEntries(string relativePath = "")
        {
            string directoryPath = Path.Combine("Templates", _projectType, relativePath);
            IDirectoryContents directoryContents = _webRootFileProvider.GetDirectoryContents(directoryPath);

            foreach (var fileSystemEntry in directoryContents)
            {
                string entryRelativePath = Path.Combine(relativePath, fileSystemEntry.Name);

                _fileTreeEntries.Add(new FileTreeEntry(ReplaceProjectTokens(entryRelativePath), fileSystemEntry.IsDirectory));

                if (fileSystemEntry.IsDirectory)
                {
                    PopulateFileTreeEntries(entryRelativePath);
                }
            }
        }

        private string ReplaceProjectTokens(string filename)
        {
            return filename.Replace("{projectName}", _projectName);
        }
    }
}