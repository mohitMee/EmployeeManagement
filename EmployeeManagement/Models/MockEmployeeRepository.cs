using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1,Name="Mohit",Department=Dept.IT,Email="mohit@meena.com"},
                new Employee() { Id = 2, Name = "Venkat", Department = Dept.HR, Email = "venkat@cud.com" },
                new Employee() { Id = 3, Name = "Mukesh", Department = Dept.PayRole, Email = "mukesh@chand.com" },
               // new Employee() { Id = 4, Name = "Lokesh", Department = Dept.IT, Email = "lokesh@kumar.com" }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
