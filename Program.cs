using System;
using System.Collections.Generic;

//inheritance
//parent child relationship
//a manager (is a)type of employee

//aggregation 
//a child object that has a single owner or parent 
//manager and employees - employees belong to manager and employees can exist independently

//association
//every employee (has a) swipe card
//they can exist independent of each other

//composition
//interdependent relationship
//lifetime of both objects is same
//project success depends on how good manager is
//manager salary depends on project success

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

    public class Employee{

        public string Name;
        public string Title;
        public DateTime JoinDate;

        
        public Employee(string name, string title, DateTime doj){
              Name=name;
              Title=title;
              JoinDate=doj;
          }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Company newCompany = new Company("Alphabeta", new DateTime(2002,04,14));
            Employee newemp1 = new Employee("Aarti", "Developer", new DateTime(2017,07,14));
            Employee newemp2 = new Employee("Manish", "Project Manager", new DateTime(2017,06,14));
            Employee newemp3 = new Employee("Rhea", "Developer", new DateTime(2017,05,14));
            newCompany.addEmployee(newemp1);
            newCompany.addEmployee(newemp2);
            newCompany.addEmployee(newemp3);
            newCompany.ListEmployees();
            newCompany.removeEmployee(newemp2);
            newCompany.ListEmployees();
            
        }
    }
}
