namespace MicrosoftLearnApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    public void Enviar(object sender, EventArgs args)
    {
        tarea.Text = input.Text;
        input.Text = "";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        tarea.Text += "  - Tarea terminada";
    }
}

