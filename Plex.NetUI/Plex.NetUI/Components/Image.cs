using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Image(string src, string alt = "") : UiComponent
{
    public string Src { get; set; } = src;
    public string Alt { get; set; } = alt;

    public override string Render()
    {
        return $"<img src='{Src}' alt='{Alt}' />";
    }
}