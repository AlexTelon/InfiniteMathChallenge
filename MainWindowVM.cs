using InfiniteMathChallenge.Utility;
using System;
using System.Windows.Input;

namespace InfiniteMathChallenge
{
    class MainWindowVM
    {
        public string CurrentQuestion { get; set; } = "1 + 2";
        public string CurrentAnswer { get; set; } = "3";

        public ICommand NextCommand { get; set; } = new RelayCommand(OnNext);

        private static void OnNext(object obj)
        {
            Console.WriteLine("Next!");
        }
    }
}
