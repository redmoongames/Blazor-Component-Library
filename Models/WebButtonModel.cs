namespace ElementsLib.Models;

public class WebButtonModel
{
    public virtual string WebStyles => GetSyles();

    private string GetSyles()
    {
        var returnString = "";
        returnString += BackgroundColor != null ? $"background-color: {BackgroundColor}; " : "";
        returnString += Width != null ? $"width: {Width}; " : "";
        returnString += Height != null ? $"height: {Height}; " : "";
        return returnString;
    }

    public WebText Text { get; set; } = "";
    public string? Reference { get; set; }
    public WebColor? BackgroundColor { get; set; }
    public WebSize? Height { get; set; }
    public WebSize? Width { get; set; }
    public string? BackgroundImageSource { get; set; }
        
    public WebButtonModel()
    {
    }
    public WebButtonModel(string text)
    {
        Text = text;
    }
}