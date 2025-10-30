using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Plex.NetUI.IComponent;

namespace Plex.NetUI.Extensions;

public static class UiComponentExtensions
{
    public static HtmlString RenderComponent(this IHtmlHelper htmlHelper, IUiComponent component)
    {
        return new HtmlString(component.Render());
    }
    
    public static HtmlString ToHtmlString(this IUiComponent component)
    {
        return new HtmlString(component.Render());
    }
}