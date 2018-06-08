using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteMathChallenge.MathEngine
{
    public class MathGenerator
    {

        public MathChallenge NextQuestion()
        {
            var challenge = new MathChallenge();

            challenge.Question = "1 + 3";
            challenge.Answer = "4";

            return challenge;
        }

    }
}
