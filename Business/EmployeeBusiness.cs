using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class EmployeeBusiness
    {
        private static int idGenerator = 1;
        private static List<Employee> employees = new List<Employee>();

        public Employee GetEmployee(int employeeId)
        {
            return employees.FirstOrDefault(x => x.Id == employeeId);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void Add(Employee employee)
        {
            employee.Id = idGenerator++;
            employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var emp = employees.FirstOrDefault(x => x.Id == employee.Id);

            if (emp == null)
            {
                throw new ApplicationException("Invalid Id");
            }

            emp.Name = employee.Name;
            emp.Desgination = employee.Desgination;
        }

        public void Delete(int employeeId)
        {
            var emp = employees.FirstOrDefault(x => x.Id == employeeId);

            if (emp == null)
            {
                throw new ApplicationException("Invalid Id");
            }

            employees.Remove(emp);
        }
    }
}
