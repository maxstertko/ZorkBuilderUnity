using System;

namespace Zork
{
    internal class ConsoleInputService : IInputService
    {
        public event EventHandler<string> InputRecieved;

        public void GetInput()
        {
            string inputString = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(inputString) == false)
            {
                // ?. same as if(InputReceived != null)
                InputRecieved?.Invoke(this, inputString);
            }
        }
    }
}
