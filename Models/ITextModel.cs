namespace ElementsLib.Models;

public interface ITextModel
{
    string Styles { get; }
    
    string Content { get; set; }
    WebSize? Size { get; set; }
    WebColor? Color { get; set; }
    string? FontFamily { get; set; }
}