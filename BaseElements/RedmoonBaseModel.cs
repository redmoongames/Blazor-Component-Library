using ElementsLib.Models;
using Microsoft.AspNetCore.Components;

namespace ElementsLib.BaseElements;

public class RedmoonBaseModel : ComponentBase
{
    /// <summary>
    /// Element model with all params
    /// </summary>
    [Parameter] public RedmoonBaseModel Child { get; set; }
    
    /// <summary>
    /// Fragment that should render inside ScaffoldingElement
    /// </summary>
    [Parameter] public RenderFragment ChildContent { get; set; }


    [Parameter] public virtual ColumnWidth Width { get; set; } = ColumnWidth.col_100;
    [Parameter] public virtual ColumnWidth LeftSpace { get; set; } = ColumnWidth.col_0;
    [Parameter] public virtual int? SpacingTop { get; set; } = 45;
    [Parameter] public virtual int? SpacingBottom { get; set; } = 45;
    
    /// <summary>
    /// Hex type color format, like: #fff or #ffffff
    /// </summary>
    [Parameter] public virtual string? BackgroundColor { get; set; }
    [Parameter] public virtual string? BackgroundFilterColor { get; set; }
    [Parameter] public virtual string? BackgroundVideo { get; set; }
    [Parameter] public virtual string? BackgroundImage { get; set; }

    [Parameter] public virtual TextAlignType GlobalTextAlignType { get; set; } = TextAlignType.Left;
    /// <summary>
    /// Set color of all inherit fonts. Hex type color format, like: #fff or #ffffff
    /// </summary>
    [Parameter] public string? GlobalTextColor { get; set; }
    [Parameter] public virtual string ElementName { get; set; } = "ElementName";

    public string GetScaffoldingClasses()
    {
        var returnString = "";
        returnString += ColumnTransformer.WidthToClassName(Width) + " ";
        returnString += ColumnTransformer.LeftSpaceToClassName(LeftSpace) + " ";
        return returnString;
    }

    public string GetScaffoldingStyles()
    {
        var returnString = "";
        returnString += SpacingTop != null ? $"padding-top: {SpacingTop}px; " : "";
        returnString += SpacingBottom != null ? $"padding-bottom: {SpacingBottom}px; " : "";
        returnString += GlobalTextAlignType != null ? $"text-align: {GlobalTextAlignType}; " : "";
        returnString += GlobalTextColor != null ? $"color: {GlobalTextColor}; " : "";
        returnString += BackgroundColor != null ? $"background-color: {BackgroundColor}; " : "";
        // returnString += MaxWidth != null ? $"max-width: {MaxWidth}px; " : "";
        return returnString;
    }
    
    [Parameter] public string ScaffoldingClasses
    {
        get => GetScaffoldingClasses();
        set => throw new NotImplementedException();
    }

    [Parameter] public string ScaffoldingStyles
    {
        get => GetScaffoldingStyles();
        set => throw new NotImplementedException();
    }
}