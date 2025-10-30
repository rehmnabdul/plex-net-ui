using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Text(string content) : UiComponent
{
    public string Content { get; set; } = content;

    public override string Render()
    {
        return $"<span>{Content}</span>";
    }
}