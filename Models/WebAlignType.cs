namespace ElementsLib.Models;


public class WebAlign
{
    public WebAlign(WebAlignType type)
    {
        Type = type;
    }

    public WebAlignType Type { get; set; }

    public static implicit operator WebAlign(WebAlignType type) => new WebAlign(type);
    public static explicit operator WebAlignType(WebAlign webAlign)
    {
        return webAlign.Type switch
        {
            WebAlignType.Left => WebAlignType.Left,
            WebAlignType.Center => WebAlignType.Center,
            WebAlignType.Right => WebAlignType.Right,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public override string ToString()
    {
        return Type switch
        {
            WebAlignType.Left => "left",
            WebAlignType.Center => "center",
            WebAlignType.Right => "right",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}

public enum WebAlignType
{
    Left,
    Center,
    Right
}