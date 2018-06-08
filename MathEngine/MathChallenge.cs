
using System;

namespace InfiniteMathChallenge.MathEngine
{
    /// <summary>
    /// The representation of a math question
    /// </summary>
    public class MathChallenge
    {
        public string Question { get; set; }

        public string Key { get; set; }

        internal bool Answer(string userAnswer)
        {
            return IsCorrect(userAnswer);
        }

        private bool IsCorrect(string answer) => (answer == Key);
    }
}
