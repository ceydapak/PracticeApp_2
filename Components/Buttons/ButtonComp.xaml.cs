namespace PracticeApp3.Components.Buttons;

public partial class ButtonComp : Button
{
	public event EventHandler C;
	public ButtonComp()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(sender != null)
		{
			C?.Invoke(sender, EventArgs.Empty);
		}
    }
}