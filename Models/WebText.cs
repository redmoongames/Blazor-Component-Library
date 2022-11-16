namespace ElementsLib.Models;

public class WebText
{
    public string Styles => GetStyles();
    public string Content { get; set; }
    public WebSize? Size { get; set; }
    public WebColor? Color { get; set; }
    public string? FontWeight { get; set; }
    public string? FontFamily { get; set; }

    private string GetStyles()
    {
        var returnString = "";
        returnString += Size != null ? $"font-size: {Size}; " : "";
        returnString += Color != null ? $"color: {Color}; " : "";
        returnString += FontWeight != null ? $"font-weight: {FontWeight};" : "";
        returnString += FontFamily != null ? $"font-family: {FontFamily};" : "";
        return returnString;
    }
    
    public WebText(string content)
    {
        Content = content;
    }
    public static implicit operator WebText(string d) => new WebText(d);
    public static explicit operator string(WebText t) => t.Content;
    public override string ToString()
    {
        return Content;
    }
}