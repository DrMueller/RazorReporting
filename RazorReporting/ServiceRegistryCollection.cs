using Lamar;

namespace RazorReporting;

public class ServiceRegistryCollection : ServiceRegistry
{
    public ServiceRegistryCollection()
    {
        Scan(scanner =>
        {
            scanner.AssemblyContainingType<ServiceRegistryCollection>();
            scanner.WithDefaultConventions();
        });
    }
}