using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Form : UiComponent
{
    public string Action { get; set; } = "";
    public string Method { get; set; } = "get";

    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        var actionAttr = !string.IsNullOrEmpty(Action) ? $" action='{Action}'" : "";
        var methodAttr = !string.IsNullOrEmpty(Method) ? $" method='{Method}'" : "";
        
        return $"<form{actionAttr}{methodAttr}>{innerHtml}</form>";
    }
}