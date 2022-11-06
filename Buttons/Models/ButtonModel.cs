namespace ElementsLib.Buttons.Models;

public class ButtonGraphicModel : ButtonModel
{
    public string? ImageSource { get; set; }
}

public class ButtonModel
{
    public string TextField { get; set; }
    public bool IsActive { get; set; }
    public bool IsSelected { get; set; }
    public string? Id { get; set; }
    public event EventHandler? ClickEvent;
    public event EventHandler? MouseEnterEvent;
    public event EventHandler? MouseExitEvent;

    public void OnClick(EventArgs e)
    {
        ClickEvent?.Invoke(this, e);
        Console.WriteLine($"Click. IsActive {IsActive}");
    }

    public void OnMouseEnter(EventArgs e)
    {
        MouseEnterEvent?.Invoke(this, e);
        Console.WriteLine($"Enter. IsSelected {IsSelected}");
    }

    public void OnMouseExit(EventArgs e)
    {
        MouseExitEvent?.Invoke(this, e);
        Console.WriteLine($"Exit. IsSelected {IsSelected}");
    }
}