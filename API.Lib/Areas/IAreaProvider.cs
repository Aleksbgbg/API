namespace Api.Lib.Areas
{
    using System.Threading.Tasks;

    public interface IAreaProvider
    {
        Task<string> Get(string url);
    }
}