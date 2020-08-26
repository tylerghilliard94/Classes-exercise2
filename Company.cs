using System;
using System.Collections.Generic;

namespace classes
{


    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
        
            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime created)
        {
            Name = name;
            CreatedOn = created;

        }

        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        public void writeEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " works for " + Name + " as " + employee.Title + " since " + employee.startDate + ".");
            }

        }
    }
}