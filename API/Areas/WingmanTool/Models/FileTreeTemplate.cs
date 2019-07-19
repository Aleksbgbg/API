namespace Api.Areas.WingmanTool.Models
{
    using System.Collections.Generic;

    public class FileTreeTemplate
    {
        public FileTreeTemplate(IEnumerable<FileTreeEntry> entries)
        {
            Entries = entries;
        }

        public IEnumerable<FileTreeEntry> Entries { get; }
    }
}