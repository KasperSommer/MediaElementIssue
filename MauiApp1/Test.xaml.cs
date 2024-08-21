namespace MauiApp1;

public partial class Test : ContentPage
{
	public Test()
	{
		InitializeComponent();
	}

	private void OnUnloaded(object? sender, EventArgs e)
	{
		mediaElement.Handler?.DisconnectHandler();
		// mediaElement.Dispose();
	}
}