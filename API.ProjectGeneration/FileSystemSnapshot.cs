namespace API.ProjectGeneration
{
    using System.Collections.Generic;
    using System.Diagnostics;

    public class FileSystemSnapshot
    {
        private readonly List<FileSystemEntry> _entries = new List<FileSystemEntry>();

        public IEnumerable<FileSystemEntry> Entries => _entries;

        public void Add(FileSystemEntry entry)
        {
            _entries.Add(entry);
        }

        public void Add(FileSystemEntry entry, FileSystemEntry parent)
        {
            Debug.Assert(parent.IsDirectory);
            Debug.Assert(_entries.Contains(parent));

            entry.AddParent(parent);

            _entries.Add(entry);
        }
    }
}