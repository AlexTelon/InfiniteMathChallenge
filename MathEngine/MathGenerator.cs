using InfiniteMathChallenge.Utility;
using System;

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
            if (IsCorrect(userAnswer))
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

        private bool IsCorrect(string answer)
        {
            return answer == Current.Key;
        }
    }
}
