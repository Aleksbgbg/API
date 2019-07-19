namespace Api.Areas.WingmanTool.Services
{
    using Microsoft.Extensions.FileProviders;
    using Microsoft.Extensions.Primitives;

    public class WebRootFileProvider : IWebRootFileProvider
    {
        private readonly IFileProvider _webRootFileProvider;

        public WebRootFileProvider(IFileProvider webRootFileProvider)
        {
            _webRootFileProvider = webRootFileProvider;
        }

        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            return _webRootFileProvider.GetDirectoryContents(subpath);
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            return _webRootFileProvider.GetFileInfo(subpath);
        }

        public IChangeToken Watch(string filter)
        {
            return _webRootFileProvider.Watch(filter);
        }
    }
}