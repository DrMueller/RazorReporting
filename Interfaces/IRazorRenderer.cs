namespace Interfaces
{
    public interface IRazorRenderer
    {
        Task<string> RenderAsync();
    }
}
