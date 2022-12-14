using System.Drawing;
using System.Globalization;

namespace ElementsLib;

public static class ColorExtension
{
    public static Color ConvertHexToColor(this Color color, string hexColor)
    {
        //Remove # if present
        if (hexColor.IndexOf('#') != -1)
            hexColor = hexColor.Replace("#", "");

        var red = 0;
        var green = 0;
        var blue = 0;

        if (hexColor.Length == 6)
        {
            //#RRGGBB
            red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
        }
        else if (hexColor.Length == 3)
        {
            //#RGB
            red = int.Parse(hexColor[0] + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
            green = int.Parse(hexColor[1] + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
            blue = int.Parse(hexColor[2] + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
        }

        return Color.FromArgb(red, green, blue);
    }
}