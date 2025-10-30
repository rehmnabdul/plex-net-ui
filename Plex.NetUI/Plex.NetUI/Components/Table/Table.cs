using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components.Table;

public class Table : UiComponent
{
    public string? ClassName { get; set; }
    
    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        var className = !string.IsNullOrEmpty(ClassName) ? $" class='{ClassName}'" : " class='table'";
        
        return $"<table{className}>{innerHtml}</table>";
    }
}