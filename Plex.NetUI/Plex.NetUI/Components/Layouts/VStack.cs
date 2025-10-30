using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class VStack : UiComponent
{
    public string? ClassName { get; set; }
    public string? Style { get; set; }

    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        var className = !string.IsNullOrEmpty(ClassName) ? $" class='{ClassName}'" : "";
        var style = !string.IsNullOrEmpty(Style) ? $" style='{Style}'" : "";
        
        return $"<div{className}{style}>{innerHtml}</div>";
    }
}