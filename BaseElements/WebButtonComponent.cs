using ElementsLib.Models;
using Microsoft.AspNetCore.Components;

namespace ElementsLib.BaseElements;

public static class StyleTransformer
{
    public static string TransformToCss(IWebStyles styles)
    {
        return "";
    }
}

public abstract class ButtonComponent : ComponentBase, IButtonStandard
{
    public virtual string? RedirectLink { get; set; }
    public virtual Action? OnClick { get; set; }
    
    public virtual int? BorderRadius { get; set; }
    public virtual int? BorderWidth { get; set; }
    public virtual WebColor? BorderColor { get; set; }
    public virtual WebColor? FontColor { get; set; }
    public virtual string? FontFamily { get; set; }
    public virtual WebSize? FontSize { get; set; }
    public virtual float? LineHeight { get; set; }
    public virtual WebFontWeightType? FontWeight { get; set; }
    public virtual WebColor? BackgroundColor { get; set; }
    public virtual string? BackgroundImage { get; set; }
    public virtual string? BackgroundVideo { get; set; }
    public virtual WebColor? BackgroundFilter { get; set; }
    public virtual bool? BackgroundFixed { get; set; }
    public virtual WebSize? MarginTop { get; set; }
    public virtual WebSize? MarginBottom { get; set; }
    public virtual WebSize? Width { get; set; }
    public virtual WebSize? Height { get; set; }

    public Dictionary<string, object> ValuesDictionary => new Dictionary<string, object>(new[]
    {
        new KeyValuePair<string, object>("RedirectLink", RedirectLink),
        new KeyValuePair<string, object>("OnClick", OnClick),
        new KeyValuePair<string, object>("BorderRadius", BorderRadius),
        new KeyValuePair<string, object>("BorderWidth", BorderWidth),
        new KeyValuePair<string, object>("BorderColor", BorderColor),
        new KeyValuePair<string, object>("FontColor", FontColor),
        new KeyValuePair<string, object>("FontFamily", FontFamily),
        new KeyValuePair<string, object>("FontSize", FontSize),
        new KeyValuePair<string, object>("LineHeight", LineHeight),
        new KeyValuePair<string, object>("FontWeight", FontWeight),
        new KeyValuePair<string, object>("BackgroundColor", BackgroundColor),
        new KeyValuePair<string, object>("BackgroundImage", BackgroundImage),
        new KeyValuePair<string, object>("BackgroundVideo", BackgroundVideo),
        new KeyValuePair<string, object>("BackgroundFilter", BackgroundFilter),
        new KeyValuePair<string, object>("BackgroundFixed", BackgroundFixed),
        new KeyValuePair<string, object>("MarginTop", MarginTop),
        new KeyValuePair<string, object>("MarginBottom", MarginBottom),
        new KeyValuePair<string, object>("Width", Width),
        new KeyValuePair<string, object>("Height", Height)
    });
}

public interface IButtonStandard : IWebStyles
{
    string RedirectLink { get; set; }
    Action OnClick { get; set; }
}

public interface IWebStyles
{
    WebSize? MarginTop { get; set; }
    WebSize? MarginBottom { get; set; }
    WebColor? BackgroundColor { get; set; }
    string? BackgroundImage { get; set; }
    string? BackgroundVideo { get; set; }
    WebColor? BackgroundFilter { get; set; }
    bool? BackgroundFixed { get; set; }
    WebColor? FontColor { get; set; }
    string? FontFamily { get; set; }
    WebSize? FontSize { get; set; }
    float? LineHeight { get; set; }
    WebFontWeightType? FontWeight { get; set; }
    int? BorderRadius { get; set; }
    int? BorderWidth { get; set; }
    WebColor? BorderColor { get; set; }
}
