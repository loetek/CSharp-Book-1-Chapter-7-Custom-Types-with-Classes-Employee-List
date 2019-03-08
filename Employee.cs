using System;

namespace EmployeeList_CustomClasses
{

            public class Employee
            {
                public string FirstName { get; set; } = "";
                public string LastName { get; set; } = "";
                public string Title { get; set; } = "";
                public DateTime StartDate { get; set; }

                public Employee (string FirstName, string LastName, string Title, DateTime StartDate)
                {
                    FirstName = "";
                    LastName = "";
                    Title = "";
                    StartDate = new DateTime (2020, 02, 02);

                }



            }



}