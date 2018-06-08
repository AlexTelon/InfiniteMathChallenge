﻿using InfiniteMathChallenge.MathEngine;
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

        public MathChallenge Challenge
        {
            get => Get<MathChallenge>();
            set => Set(value);
        }

        public int Counter
        {
            get => Get<int>();
            set => Set(value);
        }

        public ICommand NextCommand { get; set; }

        private MathGenerator Generator = new MathGenerator();

        public MainWindowVM()
        {
            NextCommand = new RelayCommand(OnNext);

            Challenge = Generator.Next();
        }

        private void OnNext(object obj)
        {
            if (IsCorrectAnswer())
            {
                Counter++;
                Challenge = Generator.Next();
                UserAnswer = "";
            }
        }

        private bool IsCorrectAnswer()
        {
            return UserAnswer == Challenge.Key;
        }
    }
}
