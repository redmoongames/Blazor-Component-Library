using Microsoft.AspNetCore.Components;

namespace ElementsLib.Texts;

public class RedmoonComponentBase : ComponentBase
{
    public string MainComponentStyles => GetStyles();

    private string GetStyles()
    {
        var returnString = "";
        returnString += SpacingTop != null ? $"padding-top: {SpacingTop}px; " : "";
        returnString += SpacingBottom != null ? $"padding-bottom: {SpacingBottom}px; " : "";
        returnString += TextAlign != null ? $"text-align: {TextAlign}; " : "";
        returnString += HexColor != null ? $"color: {HexColor}; " : "";
        returnString += MaxWidth != null ? $"max-width: {MaxWidth}px; " : "";
        return returnString;
    }

    [Parameter]
    public int? SpacingTop { get; set; }
    
    [Parameter]
    public int? SpacingBottom { get; set; }
    
    [Parameter]
    public TextAlign? TextAlign { get; set; }
    
    [Parameter]
    public int? MaxWidth { get; set; }
    
    [Parameter] public string? HexColor { get; set; }
}

public enum TextAlign
{
    Left,
    Center,
    Right
}