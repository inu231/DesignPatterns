namespace Composite.Component
{
    public interface IEmployee
    {
        string Name { get; set; }
        int WorkedHours { get; set; }

        void GetDatails();
    }
}
