using DependencyHack;
using Lamar;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using Microsoft.VisualBasic;
using Razor.Templating.Core;
using System.Diagnostics;

namespace RazorClassLibrary1;

public class ServiceRegistryCollection : ServiceRegistry
{
    public ServiceRegistryCollection()
    {
        For<IRazorRenderer>().Use<RazorRenderer>().Singleton();
        //this.AddRazorPages();
        //this.AddRazorTemplating();
    }
}