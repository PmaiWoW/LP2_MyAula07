namespace Observers_Push
{
    public interface IObserver<T>
    {
        public void Update(T key);
    }
}