using TaekwondoApp.Pages;

namespace TaekwondoApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        PreferenceButton.Clicked += async (s,e) => await PreferenceButton_ClickedAsync(s, e);
        KibonButton.Clicked += async (s,e) => await KibonButton_ClickedAsync(s, e);
        LexiqueButton.Clicked += async (s,e) => await LexiqueButton_ClickedAsync(s, e);
        HistoriqueeButton.Clicked += async (s, e) => await HistoriqueeButton_ClickedAsync(s, e);
    }

    private async Task PreferenceButton_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(Utils.Utils.NomRoutePreferencesPage);
    }

    private async Task KibonButton_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(Utils.Utils.NomRouteKibonDefinitionPage);
    }

    private async Task LexiqueButton_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(Utils.Utils.NomRouteLexiquePage);
    }

    private async Task HistoriqueeButton_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(Utils.Utils.NomRouteHistoriquePage);
    }
}

