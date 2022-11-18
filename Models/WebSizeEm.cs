namespace ElementsLib.Models;

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