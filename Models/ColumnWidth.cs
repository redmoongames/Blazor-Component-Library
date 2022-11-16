namespace ElementsLib.Models;

/// <summary>
/// maximum width = col_12
/// </summary>
public enum ColumnWidth
{
    col_0,
    col_1,
    col_2,
    col_3,
    col_4,
    col_5,
    col_6,
    col_7,
    col_8,
    col_9,
    col_10,
    col_11,
    col_12,
    col_100
}

public static class ColumnTransformer
{
    public static ColumnWidth IntToColumnWidth(int value)
    {
        return value switch
        {
            0 => ColumnWidth.col_0,
            1 => ColumnWidth.col_1,
            2 => ColumnWidth.col_2,
            3 => ColumnWidth.col_3,
            4 => ColumnWidth.col_4,
            5 => ColumnWidth.col_5,
            6 => ColumnWidth.col_6,
            7 => ColumnWidth.col_7,
            8 => ColumnWidth.col_8,
            9 => ColumnWidth.col_9,
            10 => ColumnWidth.col_10,
            11 => ColumnWidth.col_11,
            12 => ColumnWidth.col_12,
            100 => ColumnWidth.col_100,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
    }
    
    public static int ColumnWidthToInt(ColumnWidth columnWidth)
    {
        return columnWidth switch
        {
            ColumnWidth.col_0 => 0,
            ColumnWidth.col_1 => 1,
            ColumnWidth.col_2 => 2,
            ColumnWidth.col_3 => 3,
            ColumnWidth.col_4 => 4,
            ColumnWidth.col_5 => 5,
            ColumnWidth.col_6 => 6,
            ColumnWidth.col_7 => 7,
            ColumnWidth.col_8 => 8,
            ColumnWidth.col_9 => 9,
            ColumnWidth.col_10 => 10,
            ColumnWidth.col_11 => 11,
            ColumnWidth.col_12 => 12,
            ColumnWidth.col_100 => 100,
            _ => throw new ArgumentOutOfRangeException(nameof(columnWidth), columnWidth, null)
        };
    }
    
    public static string WidthToClassName(ColumnWidth columnWidth)
    {
        return columnWidth switch
        {
            ColumnWidth.col_0 => "",
            ColumnWidth.col_1 => "t-col_1",
            ColumnWidth.col_2 => "t-col_2",
            ColumnWidth.col_3 => "t-col_3",
            ColumnWidth.col_4 => "t-col_4",
            ColumnWidth.col_5 => "t-col_5",
            ColumnWidth.col_6 => "t-col_6",
            ColumnWidth.col_7 => "t-col_7",
            ColumnWidth.col_8 => "t-col_8",
            ColumnWidth.col_9 => "t-col_9",
            ColumnWidth.col_10 => "t-col_10",
            ColumnWidth.col_11 => "t-col_11",
            ColumnWidth.col_12 => "t-col_12",
            ColumnWidth.col_100 => "t-col_100",
            _ => throw new ArgumentOutOfRangeException(nameof(columnWidth), columnWidth, null)
        };
    }

    public static string LeftSpaceToClassName(ColumnWidth columnWidth)
    {
        return columnWidth switch
        {
            ColumnWidth.col_0 => "",
            ColumnWidth.col_1 => "t-prefix_1",
            ColumnWidth.col_2 => "t-prefix_2",
            ColumnWidth.col_3 => "t-prefix_3",
            ColumnWidth.col_4 => "t-prefix_4",
            ColumnWidth.col_5 => "t-prefix_5",
            ColumnWidth.col_6 => "t-prefix_6",
            ColumnWidth.col_7 => "t-prefix_7",
            ColumnWidth.col_8 => "t-prefix_8",
            ColumnWidth.col_9 => "t-prefix_9",
            ColumnWidth.col_10 => "t-prefix_10",
            ColumnWidth.col_11 => "t-prefix_11",
            ColumnWidth.col_12 => "t-prefix_12",
            ColumnWidth.col_100 => "t-prefix_100",
            _ => throw new ArgumentOutOfRangeException(nameof(columnWidth), columnWidth, null)
        };
    }
}