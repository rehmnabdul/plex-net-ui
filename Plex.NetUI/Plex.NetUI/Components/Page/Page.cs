using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components.Page;

public class Page(string title) : UiComponent
{
    public string Title { get; set; } = title;

    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        return $"<html><head><title>{Title}</title></head><body>{innerHtml}</body></html>";
    }
}
