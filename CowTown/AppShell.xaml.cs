namespace CowTown;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(LettersGame), typeof(LettersGame));

    }
}

