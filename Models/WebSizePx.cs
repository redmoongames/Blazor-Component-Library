namespace ElementsLib.Models;

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