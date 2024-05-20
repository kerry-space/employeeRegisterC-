using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            //ask user
            Console.WriteLine("Enter employee's name (or type 'exit' to end):");
            string name = Console.ReadLine();
           
           //exit program 
            if (name.ToLower() == "exit") break;

            Console.WriteLine("Enter employee's salary:");
            decimal salary = decimal.Parse(Console.ReadLine());

            //create new employe object 
            Employee employee = new  Employee(name, salary);
            //save to list of emloyees 
            employees.Add(employee);
        }

        //print out
        Console.WriteLine("\nRegistered Employees:");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary:C}");
        }
    }
}