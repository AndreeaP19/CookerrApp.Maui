namespace Cookerr.Services;

public class NavigationService : INavigationService
{
    public Task NavigateTo(string route, Dictionary<string, object> parameters = null, bool animate = true)
    {
        return GoToAsync(route, "//", parameters, animate);
    }

    public Task NavigateToRoot(string rootRoute, Dictionary<string, object> parameters = null, bool animate = true)
    {
        return GoToAsync(rootRoute, "///", parameters, animate);
    }

    public Task NavigateBack(bool animate = true)
    {
        return Shell.Current.GoToAsync("..", animate);
    }

    private Task GoToAsync(string pageRoute, string routePrefix, Dictionary<string, object> parameters, bool animate)
    {
        var route = routePrefix + pageRoute;

        return parameters == null
            ? Shell.Current.GoToAsync(route, animate)
            : Shell.Current.GoToAsync(route, animate, parameters);
    }
}