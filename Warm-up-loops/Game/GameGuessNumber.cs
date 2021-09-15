using System;
using System.Collections.Generic;
using System.Text;
using Warm_up_loops.Enum;
using Warm_up_loops.Interface;

namespace Warm_up_loops.Game
{
    public class GameGuessNumber
    {
        private int number;
        private IUserInterface ui;
        public GameGuessNumber(int number, IUserInterface ui)
        {
            this.number = number;
            this.ui = ui;
        }

        public GuessResponse Guess()
        {
            var response = ui.AskForNumber("Guess the number");

            return ProcessGuess(response);
        }

        private GuessResponse ProcessGuess(int guess)
        {
            if (number < guess)
            {
                return GuessResponse.Higher;
            }
            else if(number > guess)
            {
                return GuessResponse.Lower;
            }
            else
            {
                return GuessResponse.Correct;
            }
        }
    }
}
