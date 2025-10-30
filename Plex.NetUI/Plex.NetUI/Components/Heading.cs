using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Heading(string content, int level = 1) : UiComponent
{
    public string Content { get; set; } = content;
    public int Level { get; set; } = level;

    public override string Render()
    {
        return $"<h{Level}>{Content}</h{Level}>";
    }
}