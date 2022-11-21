namespace ElementsLib.Models;

public interface IWebStyles
{
    WebSize? MarginTop { get; set; }
    WebSize? MarginBottom { get; set; }
    WebSize? HeightOfBlock { get; set; }
    WebSize? WidthOfBlock { get; set; }
    WebColor? BackgroundColor { get; set; }
    string? BackgroundImage { get; set; }
    string? BackgroundVideo { get; set; }
    WebColor? BackgroundFilter { get; set; }
    bool? BackgroundFixed { get; set; }
    WebColor? FontColor { get; set; }
    string? FontFamily { get; set; }
    WebSize? FontSize { get; set; }
    float? FontLineHeight { get; set; }
    WebFontWeightType? FontWeight { get; set; }
    int? BorderRadius { get; set; }
    int? BorderWidth { get; set; }
    WebColor? BorderColor { get; set; }

    string ToCssString();
    Dictionary<string, object> GetValuesDictionary();
}