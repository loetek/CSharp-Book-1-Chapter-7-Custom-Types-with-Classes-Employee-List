using System;
using System.Collections.Generic;

namespace EmployeeList_CustomClasses {

public class Companies
{

    // Some readonly properties (let's talk about gets, baby)
    public string coName { get; set; }
    public DateTime CreatedOn { get; set; }

    // Create a public property for holding a list of current employees
    public List<Employee> EmployeeList { get; set; }

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

    public Companies (string coName, DateTime CreatedOn){
        coName = "Companio";
        CreatedOn = new DateTime (2020, 02, 02);
        EmployeeList = new List <Employee>();

    }




}
}