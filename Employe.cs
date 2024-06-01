using System;
using System.Collections.Generic;

namespace Personalregister{  
    public class Employee {
        private string Name {get;}
        private uint Salary {get;}

        

        public Employee(string name, uint  salary) {
            Name = name;
            Salary = salary;
        }

    
        
        public String Print(){
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}