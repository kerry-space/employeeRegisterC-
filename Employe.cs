using System;
using System.Collections.Generic;

public class Employee {
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary) {
        Name = name;
        Salary = salary;
    }
}