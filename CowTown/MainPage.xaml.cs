using System.Collections.Generic;

namespace CowTown;

public partial class MainPage : ContentPage
{
	string currentWord = "";
    List<char> lettersGiven = new List<char>();
    List<string> wordsSubmitted = new List<string>();

	public MainPage()
	{
		InitializeComponent();
        lettersGiven = CowTown.LetterUtils.GiveSevenLetters();
        GenerateLetters();
    }

	private void GenerateLetters()
	{
        EligibleLettersGrid.Children.Clear();
        lettersGiven.ForEach((letter) =>
        {
            Button letterButton = new Button();
            letterButton.Text = letter.ToString();
            letterButton.FontSize = 24;
            letterButton.Clicked += OnEligibleLetterClicked;
            EligibleLettersGrid.Children.Add(letterButton);
        });
    }

	private void OnEligibleLetterClicked(object sender, EventArgs e)
	{
		Button clickedButton = (Button)sender;
		clickedButton.Clicked -= OnEligibleLetterClicked;
		clickedButton.Clicked += OnChosenLetterClicked;
		EligibleLettersGrid.Children.Remove(clickedButton);
		ChosenLettersGrid.Children.Add(clickedButton);
        currentWord += clickedButton.Text;
		Console.WriteLine(clickedButton.Text);
	}

    private void OnChosenLetterClicked(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;
        clickedButton.Clicked += OnEligibleLetterClicked;
        clickedButton.Clicked -= OnChosenLetterClicked;
        ChosenLettersGrid.Children.Remove(clickedButton);
        EligibleLettersGrid.Children.Add(clickedButton);
        string newWord = "";
        bool letterSeen = false;
        foreach(char c in currentWord)
        {
            if(c != clickedButton.Text[0] || letterSeen)
            {
                newWord += c;
            }
            else
            {
                letterSeen = true;
            }
        }
        currentWord = newWord;
        Console.WriteLine(currentWord);

    }

    private void OnSubmitWordClicked(object sender, EventArgs e)
	{
        wordsSubmitted.Add(currentWord);
        currentWord = "";
        foreach (Button b in ChosenLettersGrid.Children)
        {
            EligibleLettersGrid.Children.Add(b);
        }
        ChosenLettersGrid.Children.Clear();
	}
}


