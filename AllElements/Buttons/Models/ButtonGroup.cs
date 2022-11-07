namespace ElementsLib.AllElements.Models;

public class ButtonGroup
{
    public List<ButtonModel> Buttons;

    private void Main()
    {
        Buttons[0].ClickEvent += (sender, args) => { };
    }
}