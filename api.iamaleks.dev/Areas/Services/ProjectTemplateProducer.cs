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

        private void PopulateFileTreeEntries(string relativePath = "")
        {
            string directoryPath = Path.Combine("Templates", _projectType, relativePath);
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
    }
}