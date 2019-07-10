namespace Api.Areas.WingmanTool.Models
{
    public class FileTreeTemplate
    {
        public FileTreeTemplate(FileTreeEntry[] entries)
        {
            Entries = entries;
        }

        public FileTreeEntry[] Entries { get; }
    }
}