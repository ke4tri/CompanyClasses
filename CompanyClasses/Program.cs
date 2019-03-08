using System;

namespace CompanyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }
            public string CurrentEmps { get; }

            // Create a property for holding a list of current employees

            // Create a method that allows external code to add an employee
            public void AddEmployee(string empoloyee)
            {
                Console.WriteLine(empoloyee);
            }
            // Create a method that allows external code to remove an employee
            public void RemoveEmployee(string empoloyee)
            {
                Console.WriteLine(empoloyee);
            }
            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
        }
    }
}
