namespace CowTown;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        Routing.RegisterRoute(nameof(LettersGame), typeof(LettersGame));

    }
}

