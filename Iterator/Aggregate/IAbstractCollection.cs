namespace Iterator.Aggregate
{
    public interface IAbstractCollection
    {
        ConcreteIterator.Iterator CreateInterator();
    }
}
