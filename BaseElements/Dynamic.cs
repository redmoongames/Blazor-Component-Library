using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace ElementsLib.BaseElements;

public class Dynamic : ComponentBase
{
    [Parameter] public HtmlTagType Tag { get; set; }
    [Parameter] public Dictionary<string, object>? AdditionalAttributes { get; set; }
    [Parameter] public string? Styles { get; set; }
    [Parameter] public string? Classes { get; set; }

    [Parameter] public RenderFragment? ChildContent { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        AdditionalAttributes ??= new Dictionary<string, object>();
        if (Styles != null) AdditionalAttributes.Add("style", Styles);
        if (Classes != null) AdditionalAttributes.Add("class", Classes);
        
        builder.OpenElement(0, Transform(Tag));
        if (AdditionalAttributes.Any())
            builder.AddMultipleAttributes(1, AdditionalAttributes);
        if (ChildContent != null)
            builder.AddContent(2, ChildContent);
        builder.CloseElement();
    }
    
    internal string Transform(HtmlTagType htmlTagType)
    {
        return htmlTagType switch
        {
            HtmlTagType.H1 => "h1",
            HtmlTagType.H2 => "h2",
            HtmlTagType.H3 => "h3",
            HtmlTagType.H4 => "h4",
            HtmlTagType.H5 => "h5",
            HtmlTagType.H6 => "h6",
            HtmlTagType.P => "p",
            _ => "p"
        };
    }
    

    public enum HtmlTagType
    {
        H1, H2, H3, H4, H5, H6, P
    }
}