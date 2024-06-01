

namespace Personalregister{
    internal class PayRoll{
        
        private List<Employee> _employees;

        public PayRoll()
        {
            _employees = new List<Employee>();
        }



        public List<Employee> GetEmployees()
        {
            //ToDo: fix not good
            return _employees.ToList();
        } 

        internal void AddEmployee(Employee employee){
            _employees.Add(employee);
        }

        public void AddEmployee(String name, uint salary){
            _employees.Add(new Employee(name, salary));
        }
    }
}