using Composite.Component;
using Composite.Leaft;
using System;
using System.Collections.Generic;

namespace Composite.Composite
{
    class Manager : IEmployee
    {
        public Manager(string name, int workedHours)
        {
            Name = name;
            WorkedHours = workedHours;
            Subordinates = new List<IEmployee>();
        }

        public string Name { get; set; }
        public int WorkedHours { get; set; }

        public List<IEmployee> Subordinates { get; set; }

        public void GetDatails()
        {
            Console.WriteLine($"Manager -> Name: {Name} - Hours worked: {WorkedHours}");

            foreach (var item in Subordinates)
            {
                item.GetDatails();
            }
        }
    }
}
