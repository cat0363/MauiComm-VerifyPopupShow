using CommunityToolkit.Maui.Views;
namespace MauiComm_VerifyPopupShow;


public partial class OnNavigatedToPage : ContentPage
{
	public OnNavigatedToPage()
	{
		InitializeComponent();
	}	

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
		await NewPopup.Show();
	}
}