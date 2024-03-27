namespace Cookerr.Services;

public interface INavigationService
{
    public Task NavigateTo(string route, Dictionary<string, object> parameters = null, bool animate = true);
    public Task NavigateToRoot(string rootRoute, Dictionary<string, object> parameters = null, bool animate = true);
    public Task NavigateBack(bool animate = true);
}