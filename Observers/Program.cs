using System;

namespace Observers
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyReader kr = new KeyReader();
            IObserver kts = new KeyToScreen();
            IObserver ktf = new KeyToFile("Aula07_ex1");

            kr.RegisterObserver(kts);
            kr.RegisterObserver(ktf);
            kr.Execute();
        }
    }
}
