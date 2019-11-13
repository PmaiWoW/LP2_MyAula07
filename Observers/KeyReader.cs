using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public class KeyReader : ISubject
    {
        private ICollection<IObserver> observers;

        public ConsoleKey LastKeyPressed { get; private set; }

        public KeyReader()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void Execute()
        {
            while(true)
            {
                LastKeyPressed = Console.ReadKey(true).Key;
                if (LastKeyPressed == ConsoleKey.Escape) break;
                foreach (IObserver obs in observers) obs.Update(this);
            }
        }
    }
}
