using System;
namespace CowTown.ViewModel
{
    public partial class MainPageViewModel
    {
        public MainPageViewModel()
        {
        }

        [RelayCommand]
        async Task GoToLettersGame()
        {
            await Shell.Current.GoToAsync(nameof(LettersGame), true);
        }

    }
}

