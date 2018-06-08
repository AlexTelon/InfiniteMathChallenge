using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteMathChallenge.MathEngine
{
    public class MathGenerator
    {

        public MathChallenge Next()
        {
            var challenge = new MathChallenge();

            Random rnd = new Random();

            var a = rnd.Next(1, 10);
            var b = rnd.Next(1, 10);
            var key = a + b;

            challenge.Question = a + " + " + b;
            challenge.Key = "" + key;

            return challenge;
        }
    }
}
