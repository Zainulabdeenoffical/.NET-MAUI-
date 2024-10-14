namespace MauiApp1;

public partial class firstpage : ContentPage
{
	public firstpage()
	{
		InitializeComponent();
	}
	private async  void  Button_Clicked (object sender, EventArgs e)
	{
		Navigation.PushAsync( new MainPage());
	}
}