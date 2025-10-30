using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components.Navigation;

public class Navigation : UiComponent
{
    public string? ClassName { get; set; }
    
    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        var className = !string.IsNullOrEmpty(ClassName) ? $" class='{ClassName}'" : " class='navigation'";
        
        return $"<nav{className}>{innerHtml}</nav>";
    }
}