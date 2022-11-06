namespace ElementsLib.Buttons.Models;

public class ButtonGroup
{
    public List<ButtonModel> Buttons;

    void Main()
    {
        Buttons[0].ClickEvent += (sender, args) =>
        {
            
        };
    }
}