using ElementsLib.BaseElements;

namespace ElementsLib.Models;

public interface IWebButtonModel : IWebBlockModel
{
    WebText TextField { get; set; }
    string? RedirectLink { get; set; }
    Action? Action { get; set; }
    WebSize? Height { get; set; }
    WebSize? Width { get; set; }
}