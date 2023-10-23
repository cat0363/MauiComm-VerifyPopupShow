using CommunityToolkit.Maui.Views;
namespace MauiComm_VerifyPopupShow;


public partial class OnLoadedPage : ContentPage
{
	public OnLoadedPage()
	{
		InitializeComponent();

		this.Loaded += OnLoaded;		
	}	

	async void OnLoaded(object? sender, EventArgs e)
	{
		this.Loaded -= OnLoaded;
		await NewPopup.Show();
	}
}