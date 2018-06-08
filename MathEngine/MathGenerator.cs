using InfiniteMathChallenge.Utility;
using System;
using System.Collections.Generic;

namespace InfiniteMathChallenge.MathEngine
{
    public class MathGenerator : BindableBase
    {
        public MathChallenge Current
        {
            get => Get<MathChallenge>();
            set => Set(value);
        }

        public int Streak
        {
            get => Get<int>();
            set => Set(value);
        }

        public ResultLog Stats { get; set; } = new ResultLog();

        public MathGenerator()
        {
            Next();
        }

        public void Next()
        {
            var tmp = new MathChallenge();

            Random rnd = new Random();

            var a = rnd.Next(1, 10);
            var b = rnd.Next(1, 10);
            var key = a + b;

            tmp.Question = a + " + " + b;
            tmp.Key = "" + key;

            Current = tmp;
        }

        internal bool Answer(string userAnswer)
        {
            bool result = Current.Answer(userAnswer);
            Stats.Log(Current, userAnswer);

            if (result)
            {
                Streak++;
                Next();
                return true;
            } else
            {
                Streak = 0;
                return false;
            }
        }

    }
}
