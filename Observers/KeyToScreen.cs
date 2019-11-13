using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public class KeyToScreen : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine((subject as KeyReader).LastKeyPressed);
        }
    }
}
