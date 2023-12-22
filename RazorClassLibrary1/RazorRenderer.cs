using System.Diagnostics;
using DependencyHack;
using Razor.Templating.Core;

namespace RazorClassLibrary1;

internal class RazorRenderer(IRazorTemplateEngine templateEngine) : IRazorRenderer
{
    public async Task<string> RenderAsync()
    {
        try
        {
            var ra = await templateEngine.RenderAsync("Reports/Page1.cshtml");
            return ra;
        }
        catch (Exception ex)
        {
            Debugger.Break();
        }

        return null;
    }
}