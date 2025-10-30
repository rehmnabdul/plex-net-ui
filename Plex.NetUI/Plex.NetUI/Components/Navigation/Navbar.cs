using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components.Navigation;

public class Navbar(string title) : UiComponent
{
    public string Title { get; set; } = title;

    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        return $"<nav class='navbar'><div class='navbar-title'>{Title}</div>{innerHtml}</nav>";
    }
}