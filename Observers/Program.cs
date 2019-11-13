using System;

namespace Observers
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyReader kr = new KeyReader();
            KeyToScreen kts = new KeyToScreen();
            KeyToFile ktf = new KeyToFile("Aula07_ex1");

            kr.RegisterObserver(kts);
            kr.RegisterObserver(ktf);
            kr.Execute();
        }
    }
}
