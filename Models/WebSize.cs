namespace ElementsLib.Models;

public abstract class WebSize
{
    public static WebSizePercent Percent100 => new WebSizePercent(100);
    public static WebSizePercent Percent50 => new WebSizePercent(50);
    public static WebSizePercent Percent33 => new WebSizePercent(33.33332f);
    public static WebSizePercent Percent25 => new WebSizePercent(25);
    public static WebSizePercent Percent20 => new WebSizePercent(20);
    public static WebSizePercent Percent12_5 => new WebSizePercent(12.5f);
    public static WebSizePercent Percent10 => new WebSizePercent(10);
    public static WebSizePercent Percent1 => new WebSizePercent(1);
    public static WebSizePx Zero => new WebSizePx(0);
    public static WebSizePx Px15 => new WebSizePx(15);
    public static WebSizePx Px30 => new WebSizePx(30);
    public static WebSizePx Px45 => new WebSizePx(45);
    public static WebSizePx Px60 => new WebSizePx(60);
    
    public override string ToString()
    {
        return $"0";
    }
    
    public static implicit operator WebSize(int pixels) => new WebSizePx(pixels);
    public static implicit operator WebSize(float ems) => new WebSizeEm(ems);
}