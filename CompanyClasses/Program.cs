using System;
using System.Collections.Generic;

namespace CompanyClasses
{
    class Program
    {
        // Can make its on file
        static void Main(string[] args)
        {
            // Make a new comany
            var ColDotCom = new Company("Colliers.com");

            // Define new employees
            var tom = new Employee("Tom", "Idiot", new DateTime());
            var john = new Employee("John", "Smart", new DateTime());
            var tate = new Employee("Tate", "Just ok", new DateTime());

            // Add the new employees
            ColDotCom.AddEmployee(tom);
            ColDotCom.AddEmployee(john);
            ColDotCom.AddEmployee(tate);

            // ColDotCom.AllEmployees();
            Console.ReadKey();
         
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
            private List<Employee> myEmployees = new List<Employee>();

            // Create a method that allows external code to add an employee
            public void AddEmployee(Employee newEmployee)
            {
                myEmployees.Add(newEmployee);
            }
            // Create a method that allows external code to remove an employee
            public void RemoveEmployee(Employee employee)
            {
                myEmployees.Remove(employee);
            }
            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */

            public Company(string comapanyCreated)
            {
                Name = comapanyCreated;
                CreatedOn = CreatedOn;
            }

            public void AllEmployees()
            {
                foreach (var emp in myEmployees)
                {
                    Console.WriteLine($"Name: {emp.EmployeeName}" + $"Job: {emp.JobTitle}" + $"Start Date: {emp.StartDate}");
                }
                return;
            }
        }

        // Can make its on file
        public class Employee
        {
            public string EmployeeName { get; set; }
            public string JobTitle { get; set; }
            public DateTime StartDate { get; set; }

            public Employee(string employeeName, string jobTitle, DateTime startDate)
            {
                EmployeeName = employeeName;
                JobTitle = jobTitle;
                StartDate = startDate;
            }
        }
    }
}
