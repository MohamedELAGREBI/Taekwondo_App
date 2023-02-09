namespace TaekwondoApp.Pages;

public partial class KibonDefinitionPage : ContentPage
{
    private const int NOMBRE_MINIMUM = 1;
    private const int NOMBRE_SEQUENCE_MAX = 10;
    private const int NOMBRE_TECHNIQUES_MAX = 5;

    private int _nombreSequences;
    private int _nombreTechniquesMax;

    public KibonDefinitionPage()
    {
        InitializeComponent();

        _nombreSequences = 5;
        nombreSequencesLabel.Text = _nombreSequences.ToString();
        _nombreTechniquesMax = 3;
        nombreTechniquesLabel.Text = _nombreTechniquesMax.ToString();

        moinsSequenceButton.Clicked += MoinsSequenceButton_Clicked;
        plusSequenceButton.Clicked += PlusSequenceButton_Clicked;
        moinsTechniqueMaxButton.Clicked += MoinsTechniqueMaxButton_Clicked;
        plusTechniqueMaxButton.Clicked += PlusTechniqueMaxButton_Clicked;
        genererKibonsButton.Clicked += async (s, e) => await GenererKibonsButton_ClickedAsync(s, e);
        annulerGenerationKibonsButton.Clicked += async (s, e) => await AnnulerGenerationKibonsButton_ClickedAsync(s, e);

    }

    private void MoinsSequenceButton_Clicked(object sender, EventArgs e)
    {
        // Si la valeur de _nombreSequences à la valeur minimale, on sort
        if (_nombreSequences == NOMBRE_MINIMUM)
        {
            return;
        }

        // On diminue la valeur de _nombreSequence et on met à jour l'affichage de la valeur
        _nombreSequences--;
        nombreSequencesLabel.Text = _nombreSequences.ToString();
    }

    private void PlusSequenceButton_Clicked(object sender, EventArgs e)
    {
        // Si la valeur de _nombreSequences à la valeur maximale, on sort
        if (_nombreSequences == NOMBRE_SEQUENCE_MAX)
        {
            return;
        }

        // On augmente la valeur de _nombreSequence et on met à jour l'affichage de la valeur
        _nombreSequences++;
        nombreSequencesLabel.Text = _nombreSequences.ToString();
    }

    private void MoinsTechniqueMaxButton_Clicked(object sender, EventArgs e)
    {
        if (_nombreTechniquesMax == NOMBRE_MINIMUM)
        {
            return;
        }

        _nombreTechniquesMax--;
        nombreTechniquesLabel.Text = _nombreTechniquesMax.ToString();
    }

    private void PlusTechniqueMaxButton_Clicked(object sender, EventArgs e)
    {
        if (_nombreTechniquesMax == NOMBRE_TECHNIQUES_MAX)
        {
            return;
        }

        _nombreTechniquesMax++;
        nombreTechniquesLabel.Text = _nombreTechniquesMax.ToString();
    }

    private async Task GenererKibonsButton_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(Utils.Utils.NomRouteKibonPage + $"?nombreSequences={_nombreSequences}&nombreTechniques{_nombreTechniquesMax}");
    }

    private async Task AnnulerGenerationKibonsButton_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}