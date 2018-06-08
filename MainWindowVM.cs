using InfiniteMathChallenge.MathEngine;
using InfiniteMathChallenge.Utility;
using System;
using System.Windows.Input;

namespace InfiniteMathChallenge
{
    class MainWindowVM : BindableBase
    {
        public string UserAnswer
        {
            get => Get<string>();
            set => Set(value);
        }

        public MathChallenge Current => Generator.Current;

        public int Streak => Generator.Streak;

        public ICommand NextCommand { get; set; }

        private MathGenerator Generator = new MathGenerator();

        public MainWindowVM()
        {
            NextCommand = new RelayCommand(OnNext);

            Generator.PropertyChanged += Generator_PropertyChanged;

            //Challenge = Generator.Next();
        }

        private void Generator_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e.PropertyName);
        }

        private void OnNext(object obj)
        {
            var correct = Generator.Answer(UserAnswer);

            if (correct)
            {
                UserAnswer = "";
            }
        }
    }
}
