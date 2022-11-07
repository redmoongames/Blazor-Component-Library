namespace ElementsLib.BaseElements;

/// <summary>
/// maximum width = col_12
/// </summary>
public enum ColumnWidth
{
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
    col_12
}

public static class ColumnTransformer
{
    public static string WidthToClassName(ColumnWidth columnWidth)
    {
        return columnWidth switch
        {
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
            _ => throw new ArgumentOutOfRangeException(nameof(columnWidth), columnWidth, null)
        };
    }

    public static string LeftSpaceToClassName(ColumnWidth columnWidth)
    {
        // .t-prefix_2
        return columnWidth switch
        {
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
            _ => throw new ArgumentOutOfRangeException(nameof(columnWidth), columnWidth, null)
        };
    }
}