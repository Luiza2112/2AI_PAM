namespace Projeto;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		//M�todo ass�ncrono que abnre um recurso (URI)
		await Launcher.OpenAsync("http://www.google.com.br");
	}
}