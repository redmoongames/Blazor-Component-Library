namespace ElementsLib.Models;

public class WebSizePercent : WebSize
{
    private float Size { get; set; }

    public WebSizePercent(float percent)
    {
        if (percent is < 0 or > 100) throw new ArgumentOutOfRangeException();
        Size = percent;
    }

    public override string ToString()
    {
        return $"{Size}%; ";
    }
}