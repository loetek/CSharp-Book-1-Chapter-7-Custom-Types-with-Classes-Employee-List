using System;
using System.Collections.Generic;

namespace EmployeeList_CustomClasses
{

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Companies myCompany = new Companies("Companio", new DateTime (2020, 02, 02));

        // Create three employees
         Employee Mike = new Employee(
                "Mike",
                "Ike",
                "CandyMan",
                new DateTime (2019,01,01)
            );

         Employee Jill = new Employee
            (
                "Jill",
                "Hill",
                "Stuntperson",
                new DateTime (2018, 01, 01)
            );

         Employee Jack = new Employee
            (
                "Jack",
                "Hill",
                "Homemaker",
                new DateTime (2017, 01, 01)
            );

        // Assign the employees to the company
        List<Employee>EmployeeList= new List<Employee>();
        myCompany.EmployeeList.Add(Mike);
        myCompany.EmployeeList.Add(Jill);
        myCompany.EmployeeList.Add(Jack);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

        EmployeeList.ForEach(emp => Console.WriteLine(emp));

         foreach(Employee emp in EmployeeList){

            Console.WriteLine(emp);
            Console.WriteLine($"{emp.FirstName} {emp.LastName} started on {emp.StartDate} and is the {emp.Title} at {myCompany.coName}");

        }

        }
    }
}

