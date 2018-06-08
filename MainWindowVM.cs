using InfiniteMathChallenge.Utility;
using System;
using System.Windows.Input;

namespace InfiniteMathChallenge
{
    class MainWindowVM : BindableBase
    {
        public string CurrentQuestion
        {
            get => Get<string>();
            set => Set(value);
        }

        public string CurrentAnswer
        {
            get => Get<string>();
            set => Set(value);
        }

        public int Counter
        {
            get => Get<int>();
            set => Set(value);
        }

        public ICommand NextCommand { get; set; }

        public MainWindowVM()
        {
            NextCommand = new RelayCommand(OnNext);

            CurrentQuestion = "1 + 3";
            CurrentAnswer = "4";
        }

        private void OnNext(object obj)
        {
            Counter++;
        }
    }
}
