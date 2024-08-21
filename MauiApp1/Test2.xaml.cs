namespace MauiApp1;

public partial class Test2 : ContentPage
{
	public Test2()
	{
		InitializeComponent();
	}

		async void OnClick(object sender, EventArgs args) 
	{
		await Shell.Current.GoToAsync("Test");
	}
}