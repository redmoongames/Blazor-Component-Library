namespace ElementsLib.Models;

public interface IWebButtonModel : IWebStyles
{
    string? RedirectLink { get; set; }
    Action? Action { get; set; }
}