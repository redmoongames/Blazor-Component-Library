namespace ElementsLib.Models;

public abstract class WebSize
{
    public override string ToString()
    {
        return $"-1px; ";
    }
    
    public static implicit operator WebSize(int pixels) => new WebSizePx(pixels);
    public static implicit operator WebSize(float ems) => new WebSizeEm(ems);
}

public static class SizeConst
{
    public static WebSizePercent Percent100 => new WebSizePercent(100);
    public static WebSizePercent Percent50 => new WebSizePercent(50);
    public static WebSizePercent Percent1 => new WebSizePercent(1);
    public static WebSizePx Zero => new WebSizePx(0);
}

public class WebSizePercent : WebSize
{
    private int Size { get; set; }

    public WebSizePercent(int percent)
    {
        if (percent is < 0 or > 100) throw new ArgumentOutOfRangeException();
        Size = percent;
    }

    public override string ToString()
    {
        return $"{Size}%; ";
    }
}
public class WebSizePx : WebSize
{
    private int Size { get; set; }

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
    private float Size { get; set; }

    public WebSizeEm(float sizeEm)
    {
        if (sizeEm < 0) throw new ArgumentOutOfRangeException();
        Size = sizeEm;
    }

    public override string ToString()
    {
        return $"{Size}em; ";
    }
}