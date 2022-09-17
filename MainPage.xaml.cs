namespace MicrosoftLearnApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    public void Enviar(object sender, EventArgs args)
    {
        DisplayAlert("Button Clicked", "You clicked the button", "OK");
    }


}

