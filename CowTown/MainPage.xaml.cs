namespace CowTown;

public partial class MainPage : ContentPage
{
	int count = 0;
	string currentWord = "";

	public MainPage()
	{
		InitializeComponent();

		for(int i = 0; i < 8; i++)
		{
			Button letterButton = new Button();
			letterButton.Text = "A";
			letterButton.FontSize = 24;
            letterButton.Clicked += OnEligibleLetterClicked;
            EligibleLettersGrid.Children.Add(letterButton);
        }

	}

	private void OnEligibleLetterClicked(object sender, EventArgs e)
	{
		Button clickedButton = (Button)sender;
		EligibleLettersGrid.Children.Remove(clickedButton);
		ChosenLettersGrid.Children.Add(clickedButton);

		Console.WriteLine(clickedButton.Text);
	}

	private void OnSubmitWordClicked(object sender, EventArgs e)
	{
	}
}


