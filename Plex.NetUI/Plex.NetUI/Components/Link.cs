using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Link(string text, string href) : UiComponent
{
    public string Text { get; set; } = text;
    public string Href { get; set; } = href;

    public override string Render()
    {
        return $"<a href='{Href}'>{Text}</a>";
    }
}