using System;

namespace Observers_Push
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyReader kr = new KeyReader();
            IObserver<ConsoleKey> kts = new KeyToScreen();
            IObserver<ConsoleKey> ktf = new KeyToFile("Aula07_ex1");

            kr.RegisterObserver(kts);
            kr.RegisterObserver(ktf);
            kr.Execute();
        }
    }
}
