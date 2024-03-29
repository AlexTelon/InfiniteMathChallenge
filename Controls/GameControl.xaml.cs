﻿using InfiniteMathChallenge.MathEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InfiniteMathChallenge.Controls
{
    /// <summary>
    /// Interaction logic for GameControl.xaml
    /// </summary>
    public partial class GameControl : UserControl
    {
        public GameControl()
        {
            InitializeComponent();
        }

        public string UserAnswer
        {
            get { return (string)GetValue(UserAnswerProperty); }
            set { SetValue(UserAnswerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserAnswer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserAnswerProperty = DependencyProperty.Register("UserAnswer", typeof(string), typeof(GameControl), new PropertyMetadata(""));


        public int Streak
        {
            get { return (int)GetValue(StreakProperty); }
            set { SetValue(StreakProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Streak.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StreakProperty = DependencyProperty.Register("Streak", typeof(int), typeof(GameControl), new PropertyMetadata(0));

        public MathChallenge CurrentChallenge
        {
            get { return (MathChallenge)GetValue(CurrentChallengeProperty); }
            set { SetValue(CurrentChallengeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentChallenge.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentChallengeProperty = DependencyProperty.Register("CurrentChallenge", typeof(MathChallenge), typeof(GameControl), new PropertyMetadata(null));






        //private static readonly IDictionary<Key, int> NumericKeys = new Dictionary<Key, int> {
        //{ Key.D0, 0 },
        //{ Key.D1, 1 },
        //{ Key.D2, 2 },
        //{ Key.D3, 3 },
        //{ Key.D4, 4 },
        //{ Key.D5, 5 },
        //{ Key.D6, 6 },
        //{ Key.D7, 7 },
        //{ Key.D8, 8 },
        //{ Key.D9, 9 },
        //{ Key.NumPad0, 0 },
        //{ Key.NumPad1, 1 },
        //{ Key.NumPad2, 2 },
        //{ Key.NumPad3, 3 },
        //{ Key.NumPad4, 4 },
        //{ Key.NumPad5, 5 },
        //{ Key.NumPad6, 6 },
        //{ Key.NumPad7, 7 },
        //{ Key.NumPad8, 8 },
        //{ Key.NumPad9, 9 }};

        //private int? GetKeyNumericValue(KeyEventArgs e)
        //{
        //    if (NumericKeys.ContainsKey(e.Key)) return NumericKeys[e.Key];
        //    else return null;
        //}

        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    var input = GetKeyNumericValue(e);

        //    if (input != null)
        //    {
        //        AnswerField.Text += input;

        //        // dont let it propagate and be used somewhere else too. Otherwise it will trigger twice if the textbox is focused
        //        // but only consider it handled if its a simple numeric value
        //        e.Handled = true;
        //    }
        //    else
        //    {
        //        if (e.Key == Key.Back)
        //        {
        //            var endIndex = Math.Max(0, (AnswerField.Text.Count() - 1));
        //            AnswerField.Text = AnswerField.Text.Substring(0, endIndex);
        //        }
        //    }

        //    // force update the binding
        //    var bindingExpression = AnswerField.GetBindingExpression(TextBlock.TextProperty);
        //    bindingExpression.UpdateSource();
        //}
    }
}
