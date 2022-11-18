using Microsoft.AspNetCore.Components;

namespace ElementsLib.Models;

public class ComponentBaseWithStyles : ComponentBase, IWebStyles
{
    [Parameter] public virtual IWebStyles CssStyles { get; set; } = new DefaultWebStyles();

    [Parameter] public WebSize? MarginTop
    {
        get => CssStyles.MarginTop;
        set => CssStyles.MarginTop = value;
    }

    [Parameter] public WebSize? MarginBottom
    {
        get => CssStyles.MarginBottom;
        set => CssStyles.MarginBottom = value;
    }

    [Parameter] public WebColor? BackgroundColor
    {
        get => CssStyles.BackgroundColor;
        set => CssStyles.BackgroundColor = value;
    }

    [Parameter] public string? BackgroundImage
    {
        get => CssStyles.BackgroundImage;
        set => CssStyles.BackgroundImage = value;
    }

    [Parameter] public string? BackgroundVideo
    {
        get => CssStyles.BackgroundVideo;
        set => CssStyles.BackgroundVideo = value;
    }

    [Parameter] public WebColor? BackgroundFilter
    {
        get => CssStyles.BackgroundFilter;
        set => CssStyles.BackgroundFilter = value;
    }

    [Parameter] public bool? BackgroundFixed
    {
        get => CssStyles.BackgroundFixed;
        set => CssStyles.BackgroundFixed = value;
    }

    [Parameter] public WebColor? FontColor
    {
        get => CssStyles.FontColor;
        set => CssStyles.FontColor = value;
    }

    [Parameter] public string? FontFamily
    {
        get => CssStyles.FontFamily;
        set => CssStyles.FontFamily = value;
    }

    [Parameter] public WebSize? FontSize
    {
        get => CssStyles.FontSize;
        set => CssStyles.FontSize = value;
    }

    [Parameter] public float? LineHeight
    {
        get => CssStyles.LineHeight;
        set => CssStyles.LineHeight = value;
    }

    [Parameter] public WebFontWeightType? FontWeight
    {
        get => CssStyles.FontWeight;
        set => CssStyles.FontWeight = value;
    }

    [Parameter] public int? BorderRadius
    {
        get => CssStyles.BorderRadius;
        set => CssStyles.BorderRadius = value;
    }

    [Parameter] public int? BorderWidth
    {
        get => CssStyles.BorderWidth;
        set => CssStyles.BorderWidth = value;
    }

    [Parameter] public WebColor? BorderColor
    {
        get => CssStyles.BorderColor;
        set => CssStyles.BorderColor = value;
    }

    public virtual string ToCssString()
    {
        return CssStyles.ToCssString();
    }
    
    public virtual Dictionary<string, object> GetValuesDictionary()
    {
        return CssStyles.GetValuesDictionary();
    }
}