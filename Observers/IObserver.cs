namespace Observers
{
    public interface IObserver
    {
        public void Update(ISubject subject);
    }
}