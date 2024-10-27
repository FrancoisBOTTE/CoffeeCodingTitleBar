namespace CoffeeCodingTitleBar;

public partial class MainWindow : Window
{
    public MainWindow()
	{
		InitializeComponent();       
	}

    private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
		var result = sender as SearchBar;
		await AppShell.Current.DisplayAlert("Search", $"You searched for {result.Text}", "OK");
    }
}