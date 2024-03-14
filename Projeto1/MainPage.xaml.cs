namespace Projeto1;

public partial class MainPage : ContentPage
{

//...............................................................

	public MainPage()
	{
		InitializeComponent();
	}
private void BotaoIniciarClick(object sender, EventArgs args)
{
   if (Application.Current != null)
	Application.Current.MainPage = new GamePage();
}

//.............................................................................................
private void BotaoSobreClick(object sender, EventArgs args)
{
	frameSobre.IsVisible = true;
}

//............................................................................................

private void BotaoSumir(object sender, EventArgs args)
{
	frameSobre.IsVisible = false;
}

}

