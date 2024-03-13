namespace Projeto1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
void joia(object sender, EventArgs args)
{
	Application.Current.MainPage = new GamePage();
}
void jonas(object sender, EventArgs args)
{
	Application.Current.MainPage = new GamePage();
}
}

