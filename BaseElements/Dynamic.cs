using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace ElementsLib.BaseElements;

public class Dynamic : ComponentBase
{
    [Parameter] public string Tag { get; set; }
    [Parameter] public Dictionary<string, object>? AdditionalAttributes { get; set; }
    [Parameter] public string? Styles { get; set; }
    [Parameter] public string? Classes { get; set; }

    [Parameter] public RenderFragment? ChildContent { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (string.IsNullOrWhiteSpace(Tag))
            throw new ArgumentNullException(nameof(Tag));

        AdditionalAttributes ??= new Dictionary<string, object>();
        if (Styles != null) AdditionalAttributes.Add("style", Styles);
        if (Classes != null) AdditionalAttributes.Add("class", Classes);
        
        builder.OpenElement(0, Tag);
        if (AdditionalAttributes.Any())
            builder.AddMultipleAttributes(1, AdditionalAttributes);
        if (ChildContent != null)
            builder.AddContent(2, ChildContent);
        builder.CloseElement();
    }
}