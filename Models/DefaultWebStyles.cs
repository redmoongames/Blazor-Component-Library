namespace ElementsLib.Models;

public class DefaultWebStyles : IWebStyles
{
    public WebSize? MarginTop { get; set; }
    public WebSize? MarginBottom { get; set; }
    public WebSize? HeightOfBlock { get; set; }
    public WebSize? WidthOfBlock { get; set; }
    public WebColor? BackgroundColor { get; set; }
    public string? BackgroundImage { get; set; }
    public string? BackgroundVideo { get; set; }
    public WebColor? BackgroundFilter { get; set; }
    public bool? BackgroundFixed { get; set; }
    public WebColor? FontColor { get; set; }
    public string? FontFamily { get; set; }
    public WebSize? FontSize { get; set; }
    public float? FontLineHeight { get; set; }
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
        returnString += HeightOfBlock != null ? $"height: {HeightOfBlock}; " : "";
        returnString += WidthOfBlock != null ? $"width: {WidthOfBlock}; " : "";
        
        returnString += BorderRadius != null ? $"border-radius: {BorderRadius}; " : "";
        returnString += BorderColor != null ? $"border: {(BorderWidth != null ? BorderWidth : "1px")} solid {BorderColor}; " : "";

        returnString += FontColor != null ? $"color: {FontColor}; " : "";
        returnString += FontSize != null ? $"font-size: {FontSize}; " : "";
        returnString += FontFamily != null ? $"font-family: {FontFamily}; " : "";
        returnString += FontWeight != null ? $"font-weight: {FontWeight}; " : "";
        returnString += FontLineHeight != null ? $"line-height: {FontLineHeight}; " : "";
        
        returnString += BackgroundColor != null ? $"background-color: {BackgroundColor}; " : "";

        return returnString;
    }

    public Dictionary<string, object> GetValuesDictionary()
    {
        var returnValue = new Dictionary<string, object>();
        
        returnValue.TryAdd(nameof(BorderRadius), BorderRadius);
        returnValue.TryAdd(nameof(BorderWidth), BorderWidth);
        returnValue.TryAdd(nameof(BorderColor), BorderColor);
        returnValue.TryAdd(nameof(FontColor), FontColor);
        returnValue.TryAdd(nameof(FontFamily), FontFamily);
        returnValue.TryAdd(nameof(FontSize), FontSize);
        returnValue.TryAdd(nameof(FontLineHeight), FontLineHeight);
        returnValue.TryAdd(nameof(FontWeight), FontWeight);
        returnValue.TryAdd(nameof(BackgroundColor), BackgroundColor);
        returnValue.TryAdd(nameof(BackgroundImage), BackgroundImage);
        returnValue.TryAdd(nameof(BackgroundVideo), BackgroundVideo);
        returnValue.TryAdd(nameof(BackgroundFilter), BackgroundFilter);
        returnValue.TryAdd(nameof(BackgroundFixed), BackgroundFixed);
        returnValue.TryAdd(nameof(MarginTop), MarginTop);
        returnValue.TryAdd(nameof(MarginBottom), MarginBottom);
        returnValue.TryAdd(nameof(HeightOfBlock), HeightOfBlock);
        returnValue.TryAdd(nameof(WidthOfBlock), WidthOfBlock);

        return returnValue;
    }
}