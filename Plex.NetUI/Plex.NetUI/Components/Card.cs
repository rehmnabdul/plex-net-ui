using Plex.NetUI.IComponent;

public class Card(string? title = null) : UiComponent
{
    public override string Render()
    {
        var innerHtml = string.Join("", Children.Select(c => c.Render()));
        return title != null 
            ? $"<div class='card'><h3>{title}</h3>{innerHtml}</div>" 
            : $"<div class='card'>{innerHtml}</div>";
    }
}
