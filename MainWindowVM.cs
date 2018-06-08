using InfiniteMathChallenge.Controls;
using InfiniteMathChallenge.MathEngine;
using InfiniteMathChallenge.Utility;
using System;
using System.Windows.Controls;
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

        public UserControl CurrentControl
        {
            get => Get<UserControl>();
            set => Set(value);
        }

        public MathChallenge Current => Generator.Current;

        public int Streak => Generator.Streak;

        public ICommand NextCommand { get; set; }
        public ICommand StatsCommand { get; set; }
        
        public MathGenerator Generator { get; set; } = new MathGenerator();

        private UserControl _gameControl = new GameControl();
        private UserControl _statsControl = new StatsControl();

        public MainWindowVM()
        {
            NextCommand = new RelayCommand(OnNext);
            StatsCommand = new RelayCommand(OnStats);

            Generator.PropertyChanged += Generator_PropertyChanged;

            CurrentControl = _gameControl;

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

        private void OnStats(object obj)
        {
            if (CurrentControl == _statsControl)
            {
                CurrentControl = _gameControl;
            }
            else
            {
                CurrentControl = _statsControl;
            }
        }
    }
}
