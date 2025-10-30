using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Button(string text, string onClick) : UiComponent
{
    public string Text { get; set; } = text;
    public string OnClick { get; set; } = onClick;

    public override string Render()
    {
        return $"<button onclick='{OnClick}'>{Text}</button>";
    }
}