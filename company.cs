using System;
using System.Collections.Generic;

namespace classes
{

    public class Company
    {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees
            //depicts aggregation relationship
            //employees have to belong to a company
            public List<Employee> Employees = new List<Employee>();
            
            // Create a method that allows external code to add an employee
            public void addEmployee(Employee emp)
            {
                Employees.Add(emp);
                
            }

            // Create a method that allows external code to remove an employee
            public void removeEmployee(Employee emp)
            {
                Employees.Remove(emp);
            }

        

            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
            public Company(string company, DateTime creationdate)
            {
                Name = company;
                CreatedOn = creationdate;
            }

            public void ListEmployees()
            {
                //Console.WriteLine("i am here");
                foreach (Employee e in Employees)
                {   
                    //Console.WriteLine("i am here");
                    Console.WriteLine(e.Name + " " + e.Title + " " + e.JoinDate);
                }
            
            }
        }
}