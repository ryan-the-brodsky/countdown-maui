namespace CowTown;

public partial class LettersGame : ContentPage
{
	public LettersGame(LettersGameViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
