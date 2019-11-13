using System;
using System.Collections.Generic;
using System.Text;

namespace Observers_Push
{
    public interface ISubject<T>
    {
        public void RegisterObserver(IObserver<T> observer);

        public void RemoveObserver(IObserver<T> observer);
    }
}
