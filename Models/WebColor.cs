using System.Drawing;

namespace ElementsLib.Models;

public static class WebColorFactory
{
    public static WebColor White => new WebColor("#fff");
    public static WebColor Black => new WebColor("#000");
}

public struct WebColor
{
    public string Hex { get; set; }

    public WebColor()
    {
        Hex = "#fff";
    }
    
    public WebColor(string hex)
    {
        Hex = hex;
    }
    
    public WebColor(Color color)
    {
        Hex = new ColorConverter().ConvertToString(color) ?? throw new ArgumentException();
    }
    
    public WebColor(ColorGradient gradient)
    {
        Hex = gradient.ToString();
    }


    public static implicit operator WebColor(string hexColor) => new WebColor(hexColor);
    public static explicit operator string(WebColor webColor) => webColor.ToString();
    
    public override string ToString()
    {
        return Hex;
    }

    public class ColorGradient
    {

        private int _deg;
        private readonly GradientPart[] _gradientPart;

        public ColorGradient(int deg, GradientPart[] gradientPart)
        {
            _deg = deg;
            _gradientPart = gradientPart;
        }

        public override string ToString()
        {
            var gradient = _gradientPart.Aggregate("", (current, part) => current + (part + ", "));
            return $"linear-gradient({_deg}deg, {gradient})";
        }

        public class GradientPart
        {
            public int Percent { get; set; }
            public Color RGBA { get; set; }

            public override string ToString()
            {
                return "rgba(46,24,132,1) 0%";
            }
        }
    }
}