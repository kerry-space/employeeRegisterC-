using System;
using System.Collections.Generic;
using Employees.Helpers;

namespace Personalregister{ 
    internal class Program
    {
        private static PayRoll _payRoll = new PayRoll();

        
        static void Main()
        {   
           

            do
            {
                showMainMeny();
                String input = Console.ReadLine();

                switch (input){
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployee();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        break; 
                }
            } while (true);

        }


        private static void AddEmployee(){
        
            String name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

        }


        private static void PrintEmployee()
        {
            List<Employee> employees = _payRoll.GetEmployees();
            
            foreach (Employee employee in employees){
                Console.WriteLine(employee.Print());

            }
            
        }
        private static void showMainMeny(){
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Print");
            Console.WriteLine("3. Quit");
        }

       //private static void AddEmployee(){
        //        _payRoll.AddEmployee("sandra", 60000);
        //        _payRoll.AddEmployee("kerry", 60000);
        //}
           
    }
}