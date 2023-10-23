namespace MauiComm_VerifyPopupShow;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		this.Loaded += OnLoaded;
	}

	async void OnLoaded(object? sender, EventArgs e)
	{
		this.Loaded -= OnLoaded;
		await NewPopup.Show();
	}
}

