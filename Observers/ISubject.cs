using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);

        public void RemoveObserver(IObserver observer);
    }
}
