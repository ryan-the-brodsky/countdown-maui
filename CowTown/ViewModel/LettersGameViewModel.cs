﻿using System;
namespace CowTown.ViewModel
{
	public partial class LettersGameViewModel : BaseViewModel
	{
		public ObservableCollection<char> EligibleLetters { get; } = new();
		public ObservableCollection<char> ChosenLetters { get; } = new();

        public LettersGameViewModel()
		{
			List<char> startingLetters = LetterUtils.GiveSevenLetters();
			foreach (char letter in startingLetters)
			{
				EligibleLetters.Add(letter);
			}
        }
	}
}
