using Microsoft.AspNetCore.Components;
using System.Drawing;

namespace ElementsLib.Texts;

public class TextSimple_razor : RedmoonComponentBase
{
    
    [Parameter]
    public TextModel Header { get; set; } = new TextModel("TextField");

    [Parameter] 
    public TextModel TextField { get; set; } = new TextModel("TextField");
}