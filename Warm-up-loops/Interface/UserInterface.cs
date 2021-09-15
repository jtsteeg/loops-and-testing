using System;
using System.Collections.Generic;
using System.Text;

namespace Warm_up_loops.Interface
{
    public interface IUserInterface
    {
        void Tell(string message);
        string Ask(string message);
        int AskForNumber(string message);
    }
}
