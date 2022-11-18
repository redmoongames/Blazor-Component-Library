using ElementsLib.Models;
using Microsoft.AspNetCore.Components;

namespace ElementsLib.BaseElements;

public interface IWebBlockModel
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

public class WebLineModel : ComponentBase, IWebBlockModel
{
    [Parameter] public virtual ColumnWidth? ContentWidth { get; set; } = ColumnWidth.col_12;
    [Parameter] public virtual ColumnWidth? LeftMargin { get; set; } = ColumnWidth.col_0;
    [Parameter] public virtual WebSize? MarginTop { get; set; } = new WebSizePx(60);
    [Parameter] public virtual WebSize? MarginBottom { get; set; } = new WebSizePx(60);
    [Parameter] public virtual WebColor? BackgroundColor { get; set; }
    [Parameter] public virtual string? BackgroundImage { get; set; }
    [Parameter] public virtual string? BackgroundVideo { get; set; }
    [Parameter] public virtual WebColor? BackgroundFilter { get; set; }
    [Parameter] public virtual bool? BackgroundFixed { get; set; }
    [Parameter] public virtual WebColor? FontColor { get; set; }
    [Parameter] public virtual string? FontFamily { get; set; }
    [Parameter] public virtual WebSize? FontSize { get; set; }
    [Parameter] public float? LineHeight { get; set; }
    [Parameter] public virtual WebFontWeightType? FontWeight { get; set; }
    [Parameter] public virtual int? BorderRadius { get; set; }
    [Parameter] public virtual int? BorderWidth { get; set; }
    [Parameter] public virtual WebColor? BorderColor { get; set; }
}

public class WebBlockModel : ComponentBase, IWebBlockModel
{
    [Parameter] public virtual WebSize? MarginTop { get; set; } = SizeConst.Zero;
    [Parameter] public virtual WebSize? MarginBottom { get; set; } = SizeConst.Zero;
    [Parameter] public virtual WebColor? BackgroundColor { get; set; }
    [Parameter] public virtual string? BackgroundImage { get; set; }
    [Parameter] public virtual string? BackgroundVideo { get; set; }
    [Parameter] public virtual WebColor? BackgroundFilter { get; set; }
    [Parameter] public virtual bool? BackgroundFixed { get; set; }
    [Parameter] public virtual WebColor? FontColor { get; set; }
    [Parameter] public virtual string? FontFamily { get; set; }
    [Parameter] public virtual WebSize? FontSize { get; set; }
    [Parameter] public virtual float? LineHeight { get; set; }
    [Parameter] public virtual WebFontWeightType? FontWeight { get; set; }
    [Parameter] public virtual int? BorderRadius { get; set; }
    [Parameter] public virtual int? BorderWidth { get; set; }
    [Parameter] public virtual WebColor? BorderColor { get; set; }
}