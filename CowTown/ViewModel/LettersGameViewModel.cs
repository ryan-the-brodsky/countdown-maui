using System;
using CommunityToolkit.Mvvm.ComponentModel;
namespace CowTown.ViewModel
{
	public partial class LettersGameViewModel : BaseViewModel
	{
		public ObservableCollection<char> EligibleLetters { get; } = new();
		public ObservableCollection<char> ChosenLetters { get; } = new();
		public string currentWord = "";

        public LettersGameViewModel()
		{
            List<char> startingLetters = LetterUtils.GiveSevenLetters();
			foreach (char letter in startingLetters)
			{
				EligibleLetters.Add(letter);
			}
        }

		[RelayCommand]
		private void EligibleLetterClick(char letter)
		{
			EligibleLetters.Remove((char)letter);
			ChosenLetters.Add((char)letter);
			currentWord += letter;
			Console.WriteLine(currentWord);
        }

		[RelayCommand]
		private void ChosenLetterClick(char letter)
		{
			ChosenLetters.Remove((char)letter);
			EligibleLetters.Add((char)letter);
            string newWord = "";
            bool letterSeen = false;
            foreach (char c in currentWord)
            {
                if (c != letter || letterSeen)
                {
                    newWord += c;
                }
                else
                {
                    letterSeen = true;
                }
            }
            currentWord = newWord;
        }
		
    }
}

