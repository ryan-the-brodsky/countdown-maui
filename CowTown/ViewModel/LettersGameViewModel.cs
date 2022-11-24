using System;
using CommunityToolkit.Mvvm.ComponentModel;
namespace CowTown.ViewModel
{
	public partial class LettersGameViewModel : BaseViewModel
	{
		public ObservableCollection<char> EligibleLetters { get; } = new();
		public ObservableCollection<char> ChosenLetters { get; } = new();
		public string CurrentWord = "";
		public List<string> SubmittedWords { get; } = new();

        public LettersGameViewModel()
		{
            List<char> StartingLetters = LetterUtils.GiveSevenLetters();
			foreach (char letter in StartingLetters)
			{
				Console.WriteLine(letter);
				EligibleLetters.Add(letter);
			}
        }

		[RelayCommand]
		private void EligibleLetterClick(char letter)
		{
			EligibleLetters.Remove((char)letter);
			ChosenLetters.Add((char)letter);
			CurrentWord += letter;
        }

		[RelayCommand]
		private void ChosenLetterClick(char letter)
		{
			ChosenLetters.Remove((char)letter);
			EligibleLetters.Add((char)letter);
            string NewWord = "";
            bool letterSeen = false;
            foreach (char c in CurrentWord)
            {
                if (c != letter || letterSeen)
                {
                    NewWord += c;
                }
                else
                {
                    letterSeen = true;
                }
            }
            CurrentWord = NewWord;
        }

		[RelayCommand]
		private void SubmitWord()
		{
			SubmittedWords.Add(CurrentWord);
			CurrentWord = "";
			foreach(char c in ChosenLetters)
			{
				EligibleLetters.Add(c);
			}
			ChosenLetters.Clear();
		}
    }
}

