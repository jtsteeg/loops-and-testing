using System;
using System.Collections.Generic;
using System.Text;
using Warm_up_loops.Interface;

namespace Warm_up_loops
{
    public class UserInterface : IUserInterface
    {
        public void Tell(string message)
        {
            Console.WriteLine(message);
        }

        public string Ask(string message)
        {
            Console.WriteLine(message);

            return Console.ReadLine();
        }

        public int AskForNumber(string message)
        {
            var response = Ask(message);
            int number;

            if(!Int32.TryParse(response, out number))
            {
                AskForNumber(message);
            }

            return number;
        }
    }
}
