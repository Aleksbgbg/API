namespace Api.Lib.Clients
{
    using System.Threading.Tasks;

    public interface IGitClient
    {
        Task<string> GetGitAttributes();

        Task<string> GetGitIgnore();
    }
}