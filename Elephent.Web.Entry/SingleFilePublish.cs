using Furion;
using System.Reflection;

namespace Elephent.Web.Entry;

public class SingleFilePublish : ISingleFilePublish
{
    public Assembly[] IncludeAssemblies()
    {
        return Array.Empty<Assembly>();
    }

    public string[] IncludeAssemblyNames()
    {
        return new[]
        {
            "Elephent.Application",
            "Elephent.Core",
            "Elephent.EntityFramework.Core",
            "Elephent.Web.Core"
        };
    }
}