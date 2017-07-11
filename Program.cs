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
