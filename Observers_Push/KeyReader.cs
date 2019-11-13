using System;
using System.Collections.Generic;
using System.Text;

namespace Observers_Push
{
    public class KeyReader : ISubject<ConsoleKey>
    {
        private ICollection<IObserver<ConsoleKey>> observers;

        public ConsoleKey LastKeyPressed { get; private set; }

        public KeyReader()
        {
            observers = new List<IObserver<ConsoleKey>>();
        }

        public void RegisterObserver(IObserver<ConsoleKey> obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver<ConsoleKey> obs)
        {
            observers.Remove(obs);
        }

        public void Execute()
        {
            while(true)
            {
                ConsoleKey key;
                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape) break;
                foreach (IObserver<ConsoleKey> obs in observers) obs.Update(key);
            }
        }
    }
}
