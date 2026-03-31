namespace NewApp1.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private async void OnClick(object sender, EventArgs e)
    {
        await DisplayAlert("Путь", FileSystem.AppDataDirectory, "OK");
    }
}