#if DEBUG
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("{projectName}.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif