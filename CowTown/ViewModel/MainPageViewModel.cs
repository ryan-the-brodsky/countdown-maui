using System;
namespace CowTown.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
        }

        [RelayCommand]
        async Task GoToLettersGame()
        {
            Console.Write("HERE");
            await Shell.Current.GoToAsync(nameof(LettersGame), true);
        }

    }
}

