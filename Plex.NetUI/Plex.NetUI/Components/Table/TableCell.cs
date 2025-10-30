using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components.Table;

public class TableCell(string content) : UiComponent
{
    public string Content { get; set; } = content;

    public override string Render()
    {
        return $"<td>{Content}</td>";
    }
}