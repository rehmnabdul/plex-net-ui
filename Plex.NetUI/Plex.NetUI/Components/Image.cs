using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Image(string src, string alt = "", int? width = null, int? height = null) : UiComponent
{
    public override string Render()
    {
        var widthAttr = width.HasValue ? $" width='{width.Value}'" : "";
        var heightAttr = height.HasValue ? $" height='{height.Value}'" : "";
        return $"<img src='{src}' alt='{alt}'{widthAttr}{heightAttr} />";
    }
}