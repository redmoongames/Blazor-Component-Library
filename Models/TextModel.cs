using System.Drawing;

namespace ElementsLib.Models;

public class TextModel
{
    private string _hexColor = "#000000";

    public TextModel(string content, string fontName = "default", int fontSizeEm = 1, string hexColor = "#000")
    {
        Text = content;
        HexColor = hexColor;
        FontName = fontName == "default" ? null : fontName;
        FontSizeEm = fontSizeEm;
    }

    public string Styles => GetMainModelStyles();

    public string? HexColor
    {
        get => _hexColor;
        set
        {
            if (value == null) throw new NullReferenceException();
            _hexColor = CheckHexColor(value) ? value : "#ff0000";
        }
    }

    public Color? Color
    {
        get => new Color().ConvertHexToColor(_hexColor);
        set
        {
            if (value == null) throw new NullReferenceException();
            _hexColor = new ColorConverter().ConvertToString(value) ?? "#ff0000";
        }
    }

    public float? FontSizeEm { get; set; } = 1;
    public string? FontName { get; set; }
    public string Text { get; set; } = "";


    private string GetMainModelStyles()
    {
        var returnString = "";

        returnString += Color != null || HexColor != null ? $"color: {_hexColor}; " : "";

        returnString += FontSizeEm != null ? "" : $"font-size: {FontSizeEm}em; ";

        returnString += string.IsNullOrWhiteSpace(FontName) ? "" : $"font-family: {FontName}; ";

        return returnString;
    }

    public static string TransformColor(Color color)
    {
        var stringColor = new ColorConverter().ConvertToString(color);
        return stringColor ?? throw new Exception();
    }
    
    public static implicit operator TextModel(string d) => new TextModel(d);
    public static explicit operator string(TextModel t) => t.Text;
    public override string ToString()
    {
        return Text;
    }

    private bool CheckHexColor(string? hexColor)
    {
        try
        {
            new Color().ConvertHexToColor(hexColor);
        }
        catch (Exception e)
        {
            return false;
        }

        return true;
    }
}