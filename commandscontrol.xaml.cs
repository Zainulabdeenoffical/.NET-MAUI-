namespace MauiApp1;

public partial class commandscontrol : ContentPage
{
	public commandscontrol()
	{
		InitializeComponent();
	}
        
	private void  clickbtn_1(object sender,EventArgs e)
	{
		DisplayAlert("Thanks"," for cliking","ok");
	}
	private void radioevent(object sender, CheckedChangedEventArgs e)
	{

        DisplayAlert("option Selection", $"selected:{e.Value}","ok");
	}
	private void searched(object sender, EventArgs e)
	{
		DisplayAlert("Searching Text",$"your searched text is {searching.Text}","ok");
	}
    private void swipeiteminvoked(object sender, EventArgs e)
    {
       
    }
}