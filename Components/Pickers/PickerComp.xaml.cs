namespace PracticeApp3.Components.Pickers;

public partial class PickerComp : Picker
{

    public event EventHandler PickerSelect;
    public PickerComp()
	{
		InitializeComponent();
	}

    private void pickerComp_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(sender != null)
        {
            PickerSelect?.Invoke(this, EventArgs.Empty);
        }
    }
}