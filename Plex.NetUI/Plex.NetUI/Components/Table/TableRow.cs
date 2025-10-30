using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components.Table;

public class TableRow : UiComponent
{
    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        return $"<tr>{innerHtml}</tr>";
    }
}