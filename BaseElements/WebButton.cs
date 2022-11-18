using ElementsLib.Models;
using Microsoft.AspNetCore.Components;

namespace ElementsLib.BaseElements;

public class WebButton : ComponentBaseWithStyles
{
    [Parameter] public virtual string? RedirectLink { get; set; } = "/";
    [Parameter] public virtual Action? OnClick { get; set; }
}