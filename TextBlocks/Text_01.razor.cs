using Microsoft.AspNetCore.Components;

namespace ElementsLib.BaseElements;

public class TextSimple_razor : RedmoonBaseModel
{
    [Parameter] public TextModel Header { get; set; } = new("TextField");

    [Parameter] public TextModel TextField { get; set; } = new("TextField");
}