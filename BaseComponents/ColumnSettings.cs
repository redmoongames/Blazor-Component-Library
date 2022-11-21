using ElementsLib.Models;

namespace ElementsLib.BaseElements;

public class ColumnSettings
{
    public ColumnWidth? ContentWidth { get; set; }
    public ColumnWidth? LeftSpace { get; set; }

    public ColumnSettings(ColumnWidth contentWidth = ColumnWidth.col_12, ColumnWidth leftSpace = ColumnWidth.col_0)
    {
        ContentWidth = contentWidth;
        LeftSpace = leftSpace;
    }
}