namespace TaekwondoApp.Pages;

[QueryProperty(nameof(NombreSequences), "nombreSequences")]
[QueryProperty(nameof(NombreTechniques), "nombreTechniques")]
public partial class KibonPage : ContentPage
{
    public int NombreSequences { get; set; }
    public int NombreTechniques { get; set; }

    public KibonPage()
    {
        InitializeComponent();

        nombreSeqLabel.Text = "Nombre de séquences : " + NombreSequences;
        nombreTecLabel.Text = "Nombre de techniques : " + NombreTechniques;

        kibonPrecedentButton.Clicked += kibonPrecedentButton_Clicked;
        kibonSuivantButton.Clicked += kibonSuivantButton_Clicked;
        versExplicationsKibonsButton.Clicked += async (s, e) => await versExplicationsKibonsLabel_ClickedAsync(s, e);
        terminerButton.Clicked += async (s, e) => await terminerButton_ClickedAsync(s, e);

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var nbSeq = QueryPropertyAttribute.GetCustomAttribute(nameof(NombreSequences), typeof(int));
    }

    private void kibonPrecedentButton_Clicked(object sender, EventArgs e)
    {

    }

    private void kibonSuivantButton_Clicked(Object sender, EventArgs e)
    {

    }

    private async Task versExplicationsKibonsLabel_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(Utils.Utils.NomRouteTechniquePage);
    }

    private async Task terminerButton_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(Utils.Utils.NomRouteMainPage);
    }
}