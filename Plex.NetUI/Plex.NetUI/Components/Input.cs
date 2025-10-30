using Plex.NetUI.IComponent;

namespace Plex.NetUI.Components;

public class Input(string type, string placeholder = "") : UiComponent
{
    public string Type { get; set; } = type;
    public string Placeholder { get; set; } = placeholder;
    public string Value { get; set; } = "";

    public override string Render()
    {
        var valueAttr = !string.IsNullOrEmpty(Value) ? $" value='{Value}'" : "";
        var placeholderAttr = !string.IsNullOrEmpty(Placeholder) ? $" placeholder='{Placeholder}'" : "";
        
        return $"<input type='{Type}'{placeholderAttr}{valueAttr} />";
    }
}