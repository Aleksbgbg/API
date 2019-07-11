namespace Api.Areas.WingmanTool.Services
{
    using System.IO;
    using System.Threading.Tasks;

    public class GitFileProvider : IGitFileProvider
    {
        private readonly IWebRootFileProvider _webRootFileProvider;

        public GitFileProvider(IWebRootFileProvider webRootFileProvider)
        {
            _webRootFileProvider = webRootFileProvider;
        }

        public Task<string> ReadGitAttributes()
        {
            return ReadGitFile("gitattributes");
        }

        public Task<string> ReadGitIgnore()
        {
            return ReadGitFile("gitignore");
        }

        private async Task<string> ReadGitFile(string filename)
        {
            await using Stream stream = _webRootFileProvider.GetFileInfo(Path.Combine("git", filename)).CreateReadStream();
            using StreamReader streamReader = new StreamReader(stream);

            return await streamReader.ReadToEndAsync();
        }
    }
}