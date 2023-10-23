using CommunityToolkit.Maui.Views;
namespace MauiComm_VerifyPopupShow;

public partial class NewPopup : Popup
{
	public NewPopup()
	{
		InitializeComponent();
	}

	public static async Task Show()
	{
		var popup = new NewPopup();
		popup.Opened += (s, e) => Task.Delay(500).ContinueWith(s =>
		{
			Thread.Sleep(1000);
			MainThread.BeginInvokeOnMainThread(() => popup.Close());
		});

		await Shell.Current.ShowPopupAsync(popup);
	}
}