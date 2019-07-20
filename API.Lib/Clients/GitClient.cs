namespace Api.Lib.Clients
{
    using System.Threading.Tasks;

    using Api.Lib.Areas;

    public class GitClient : IGitClient
    {
        private readonly IWingmanToolAreaProvider _wingmanArea;

        public GitClient(IWingmanToolAreaProvider wingmanArea)
        {
            _wingmanArea = wingmanArea;
        }

        public Task<string> GetGitAttributes()
        {
            return GetGit("attributes");
        }

        public Task<string> GetGitIgnore()
        {
            return GetGit("ignore");
        }

        private Task<string> GetGit(string handler)
        {
            return _wingmanArea.Get($"git/{handler}");
        }
    }
}