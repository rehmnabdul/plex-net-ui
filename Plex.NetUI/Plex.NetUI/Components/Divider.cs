using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Divider : UiComponent
{
    public override string Render()
    {
        return "<hr />";
    }
}