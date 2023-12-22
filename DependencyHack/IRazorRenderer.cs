namespace DependencyHack
{
    public interface IRazorRenderer
    {
        Task<string> RenderAsync();
    }
}
