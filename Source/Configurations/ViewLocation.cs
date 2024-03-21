using Microsoft.AspNetCore.Mvc.Razor;

namespace Shopopolis.Source.Configurations;

class ViewLocation : IViewLocationExpander
{
    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
    {
        yield return "/Source/Web/Views/Shared/{0}" + RazorViewEngine.ViewExtension;
        yield return "/Source/Web/Views/Pages/{1}/{0}" + RazorViewEngine.ViewExtension;
    }

    public void PopulateValues(ViewLocationExpanderContext context) { }
}
