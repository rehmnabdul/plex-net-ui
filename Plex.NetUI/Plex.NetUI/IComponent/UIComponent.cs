namespace Plex.NetUI.IComponent;

public abstract class UiComponent : IUiComponent
{
    public List<IUiComponent> Children { get; set; } = [];

    public abstract string Render();
}