using System;
using System.Collections.Generic;
using System.Text;

namespace Observers_Push
{
    public class KeyToScreen : IObserver<ConsoleKey>
    {
        public void Update(ConsoleKey key)
        {
            Console.WriteLine(key);
        }
    }
}
