namespace ElementsLib.Models;

public class DefaultWebStyles : IWebStyles
{
    public WebSize? MarginTop { get; set; }
    public WebSize? MarginBottom { get; set; }
    public WebColor? BackgroundColor { get; set; }
    public string? BackgroundImage { get; set; }
    public string? BackgroundVideo { get; set; }
    public WebColor? BackgroundFilter { get; set; }
    public bool? BackgroundFixed { get; set; }
    public WebColor? FontColor { get; set; }
    public string? FontFamily { get; set; }
    public WebSize? FontSize { get; set; }
    public float? LineHeight { get; set; }
    public WebFontWeightType? FontWeight { get; set; }
    public int? BorderRadius { get; set; }
    public int? BorderWidth { get; set; }
    public WebColor? BorderColor { get; set; }
    public string ToCssString()
    {
        return ToString();
    }

    public override string ToString()
    {
        var returnString = "";
        
        returnString += MarginTop != null ? $"padding-top: {MarginTop}; " : "";
        returnString += MarginBottom != null ? $"padding-bottom: {MarginBottom}; " : "";
        
        returnString += BorderRadius != null ? $"border-radius: {BorderRadius}; " : "";
        returnString += BorderColor != null ? $"border: {(BorderWidth != null ? BorderWidth : "1px")} solid {BorderColor}; " : "";

        returnString += FontColor != null ? $"color: {FontColor}; " : "";
        returnString += FontSize != null ? $"font-size: {FontSize}; " : "";
        returnString += FontFamily != null ? $"font-family: {FontFamily}; " : "";
        returnString += FontWeight != null ? $"font-weight: {FontWeight}; " : "";
        returnString += LineHeight != null ? $"line-height: {LineHeight}; " : "";
        
        returnString += BackgroundColor != null ? $"background-color: {BackgroundColor}; " : "";

        return returnString;
    }

    public Dictionary<string, object> GetValuesDictionary()
    {
        var returnValue = new Dictionary<string, object>();
        
        returnValue.TryAdd("BorderRadius", BorderRadius);
        returnValue.TryAdd("BorderWidth", BorderWidth);
        returnValue.TryAdd("BorderColor", BorderColor);
        returnValue.TryAdd("FontColor", FontColor);
        returnValue.TryAdd("FontFamily", FontFamily);
        returnValue.TryAdd("FontSize", FontSize);
        returnValue.TryAdd("LineHeight", LineHeight);
        returnValue.TryAdd("FontWeight", FontWeight);
        returnValue.TryAdd("BackgroundColor", BackgroundColor);
        returnValue.TryAdd("BackgroundImage", BackgroundImage);
        returnValue.TryAdd("BackgroundVideo", BackgroundVideo);
        returnValue.TryAdd("BackgroundFilter", BackgroundFilter);
        returnValue.TryAdd("BackgroundFixed", BackgroundFixed);
        returnValue.TryAdd("MarginTop", MarginTop);
        returnValue.TryAdd("MarginBottom", MarginBottom);

        return returnValue;
    }
}