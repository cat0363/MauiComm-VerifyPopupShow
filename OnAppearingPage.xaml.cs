using CommunityToolkit.Maui.Views;
namespace MauiComm_VerifyPopupShow;


public partial class OnAppearingPage : ContentPage
{
	public OnAppearingPage()
	{
		InitializeComponent();
	}	

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await NewPopup.Show();
	}
}