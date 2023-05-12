using Composite.Component;
using System;

namespace Composite.Leaft
{
    public class Employee : IEmployee
    {
        public Employee(string name, int workedHours)
        {
            Name = name;
            WorkedHours = workedHours;
        }

        public string Name { get; set; }
        public int WorkedHours { get; set; }

        public void GetDatails()
        {
            Console.WriteLine($"Employee ------> Name: {Name} - Hours worked: {WorkedHours}");
        }
    }
}
