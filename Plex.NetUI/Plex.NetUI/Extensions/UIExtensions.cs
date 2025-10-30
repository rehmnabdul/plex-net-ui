using Plex.NetUI.IComponent;

namespace Plex.NetUI.Extensions;

public static class UiExtensions
{
    public static T Add<T>(this T parent, IUiComponent child) where T : UiComponent
    {
        parent.Children.Add(child);
        return parent;
    }
}