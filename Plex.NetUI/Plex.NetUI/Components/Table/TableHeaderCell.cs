using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components.Table;

public class TableHeaderCell(string content) : UiComponent
{
    public string Content { get; set; } = content;

    public override string Render()
    {
        return $"<th>{Content}</th>";
    }
}