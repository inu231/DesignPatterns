using Composite.Composite;
using Composite.Leaft;
using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var itManager = new Manager("John", 10)
            {
                Subordinates = new List<Component.IEmployee>()
                {
                    new Employee("Felipe", 900),
                    new Employee("Tales", 500),
                    new Employee("Rafael", 400),
                    new Employee("Juliana", 300),
                }
            };


            itManager.GetDatails();

            Console.WriteLine("****************************************************");

            var arquitectureManager = new Manager("Arnold", 10)
            {
                Subordinates = new List<Component.IEmployee>()
                {
                    new Employee("Luciano", 200),
                    new Employee("Bruna", 100),                    
                }
            };

            arquitectureManager.GetDatails();
        }
    }
}
