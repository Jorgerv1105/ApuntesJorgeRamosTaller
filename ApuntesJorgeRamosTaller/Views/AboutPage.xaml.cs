namespace ApuntesJorgeRamosTaller.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://learn.microsoft.com/dotnet/maui/");
    }
}