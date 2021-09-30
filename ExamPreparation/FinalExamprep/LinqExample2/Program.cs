using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>()
            {new Employees(){ID=1234,name="upama"},
            new Employees(){ID=1235,name="Sazida"},
            new Employees(){ID=1236,name="maisha"}
            };

            var basicquery = (from emp in employee
                              select emp).ToList();
            var basicmethod = employee.ToList();
            foreach (var item in basicquery)
            {
                Console.WriteLine($"Employee ID: {item.ID} and Employee Name: {item.name}");
            }
            
            var basicproquery= (from emp in employee
                                select emp.ID).ToList();

            var selectQuery = (from emp1 in employee
                               select new Student()
                               {
                                   StudentID = emp1.ID,
                                   StName = emp1.name
                               }).ToList();

            var selectsQuery = (from emp1 in employee //this is called anonymous type
                               select new 
                               {
                                   CustomerID = emp1.ID,
                                   CustomarName= emp1.name 
                               }).ToList();

            var SelectMethod = employee.Select(emp => new Student()
            {
                StudentID = emp.ID,
                StName = emp.name
            }).ToList();

            var selectsMethod= employee.Select(emp => new 
            {
                CostomerID = emp.ID,
                CostomerName = emp.name
            }).ToList();

            //Select Data by using the index

            var query = employee.Select((emp, index) => new { Index = index, FullName = emp.name }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Student ID: {item.StudentID} and Student Name: {item.StName}");
            }
        }
    }
}
