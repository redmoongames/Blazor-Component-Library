namespace ElementsLib.Models;

public abstract class WebSize
{
    public abstract int Size { get; set; }

    public override string ToString()
    {
        return $"-1px; ";
    }
}

public class WebSizePercent : WebSize
{
    public override int Size { get; set; }

    public WebSizePercent(int percent)
    {
        if (percent is < 0 or > 100) throw new ArgumentOutOfRangeException();
        Size = percent;
    }

    public override string ToString()
    {
        return $"{Size}px; ";
    }
}
public class WebSizePx : WebSize
{
    public override int Size { get; set; }

    public WebSizePx(int sizePx)
    {
        if (sizePx < 0) throw new ArgumentOutOfRangeException();
        Size = sizePx;
    }

    public override string ToString()
    {
        return $"{Size}px; ";
    }
}

public class WebSizeEm : WebSize 
{
    public override int Size { get; set; }

    public WebSizeEm(int sizeEm)
    {
        if (sizeEm < 0) throw new ArgumentOutOfRangeException();
        Size = sizeEm;
    }

    public override string ToString()
    {
        return $"{Size}em; ";
    }
}

public class WebText : ITextModel
{
    public string Styles => GetStyles();
    public string Content { get; set; }
    public WebSize? Size { get; set; }
    public WebColor? Color { get; set; }
    public string? FontWeight { get; set; }
    public string? FontFamily { get; set; }

    private string GetStyles()
    {
        var returnString = "";
        returnString += Size != null ? $"font-size: {Size}; " : "";
        returnString += Color != null ? $"color: {Color.Hex}; " : "";
        returnString += FontWeight != null ? $"font-weight: {FontWeight};" : "";
        returnString += FontFamily != null ? $"font-family: {FontFamily};" : "";
        return returnString;
    }
    
    public WebText(string content)
    {
        Content = content;
    }
    public static implicit operator WebText(string d) => new WebText(d);
    public static explicit operator string(WebText t) => t.Content;
    public override string ToString()
    {
        return Content;
    }
}