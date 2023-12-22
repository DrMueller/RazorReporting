using Interfaces;
using Lamar;

namespace RazorClassLibrary1;

public class ServiceRegistryCollection : ServiceRegistry
{
    public ServiceRegistryCollection()
    {
        For<IRazorRenderer>().Use<RazorRenderer>().Singleton();
    }
}