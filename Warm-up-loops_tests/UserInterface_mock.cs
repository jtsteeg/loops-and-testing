using System;
using System.Collections.Generic;
using System.Text;
using Warm_up_loops.Interface;

namespace Warm_up_loops_tests
{
    public class UserInterface_mock : IUserInterface
    {
        private Queue<string> asks = new Queue<string>();
        private Queue<int> asksForNumber = new Queue<int>();

        public UserInterface_mock() { }
        public void Tell(string message)
        {
            // Do Nothing
        }

        public string Ask(string message)
        {
            return asks.Dequeue();
        }

        public void AddAskToQueue(string message)
        {
            asks.Enqueue(message);
        }

        public int AskForNumber(string message)
        {
            return asksForNumber.Dequeue();
        }

        public void AddToNumberQueue(int number)
        {
            asksForNumber.Enqueue(number);
        }
    }
}
