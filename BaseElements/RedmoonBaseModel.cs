using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

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
    

    [Parameter] public ColumnWidth Width { get; set; }
    [Parameter] public ColumnWidth LeftSpace { get; set; }
    [Parameter] public int? SpacingTop { get; set; }
    [Parameter] public int? SpacingBottom { get; set; }
    
    /// <summary>
    /// Hex type color format, like: #fff or #ffffff
    /// </summary>
    [Parameter] public string? BlockBackgroundColor { get; set; }

    [Parameter] public virtual TextAlign GlobalTextAlign { get; set; } = TextAlign.Left;
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
        returnString += GlobalTextAlign != null ? $"text-align: {GlobalTextAlign}; " : "";
        returnString += GlobalTextColor != null ? $"color: {GlobalTextColor}; " : "";
        returnString += BlockBackgroundColor != null ? $"background-color: {BlockBackgroundColor}; " : "";
        // returnString += MaxWidth != null ? $"max-width: {MaxWidth}px; " : "";
        return returnString;
    }
    
    [Parameter] public string ScaffoldingClasses { get; set; } = "";
    [Parameter] public string ScaffoldingStyles { get; set; } = "";
    

    protected override void OnInitialized()
    {
        ScaffoldingClasses = GetScaffoldingClasses();
        ScaffoldingStyles = GetScaffoldingStyles();
        base.OnInitialized();
    }
}