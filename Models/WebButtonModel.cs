// namespace ElementsLib.Models;
//
// public class WebButtonModel
// {
//     public virtual string WebStyles => GetSyles();
//
//     private string GetSyles()
//     {
//         var returnString = "";
//         returnString += BackgroundColor != null ? $"background-color: {BackgroundColor}; " : "";
//         return returnString;
//     }
//
//     public WebText Text { get; set; } = "";
//     public string? Reference { get; set; }
//     public WebColor? BackgroundColor { get; set; }
//     public string? BackgroundImage { get; set; }
//     public Action? Action { get; set; }
//
//     public WebButtonModel()
//     {
//     }
//     public WebButtonModel(string text)
//     {
//         Text = text;
//     }
// }