using TaekwondoApp.Pages;

namespace TaekwondoApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(Utils.Utils.NomRouteMainPage, typeof(MainPage));
        Routing.RegisterRoute(Utils.Utils.NomRouteLexiquePage, typeof(AllTechniquesPage));
		Routing.RegisterRoute(Utils.Utils.NomRouteTechniquePage, typeof(TechniquePage));
        Routing.RegisterRoute(Utils.Utils.NomRouteKibonDefinitionPage, typeof(KibonDefinitionPage));
        Routing.RegisterRoute(Utils.Utils.NomRouteKibonPage, typeof(KibonPage));
        Routing.RegisterRoute(Utils.Utils.NomRoutePreferencesPage, typeof(PreferencesPage));
        Routing.RegisterRoute(Utils.Utils.NomRouteHistoriquePage, typeof(HistoriquePage));
    }
}
