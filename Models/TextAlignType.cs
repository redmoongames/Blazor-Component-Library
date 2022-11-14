namespace ElementsLib.Models;


public class WebTextAlign
{
    public TextAlignType Type { get; set; }

    public WebTextAlign(TextAlignType type)
    {
        Type = type;
    }

    public override string ToString()
    {
        switch (Type)
        {
            case TextAlignType.Left:
                return "left";
            case TextAlignType.Center:
                return "center";
            case TextAlignType.Right:
                return "right";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

public enum TextAlignType
{
    Left,
    Center,
    Right
}