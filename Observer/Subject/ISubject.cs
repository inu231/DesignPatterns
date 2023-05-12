using Observer.Observers;

namespace Observer.Subject
{
    public interface ISubject
    {
        void NotificarObservers();

        void RegistrarObserver(IObserver observer);

        void RemoverObserver(IObserver observer);
    }
}
