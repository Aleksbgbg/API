namespace Api.Areas.WingmanTool.Services
{
    using System.Threading.Tasks;

    public interface IGitFileProvider
    {
        Task<string> ReadGitAttributes();

        Task<string> ReadGitIgnore();
    }
}