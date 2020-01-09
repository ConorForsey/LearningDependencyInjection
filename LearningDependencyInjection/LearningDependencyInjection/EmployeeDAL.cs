using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDependencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> GetAllEmployees();
    }

    public class EmployeeDAL : IEmployeeDAL //Employee data access layer
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { ID = 1, Name = "Conor",  Department = "IT"});
            listEmployees.Add(new Employee() { ID = 2, Name = "Alex",   Department = "Payroll" });
            listEmployees.Add(new Employee() { ID = 3, Name = "Karina", Department = "HR" });

            return listEmployees;
        }
    }
}
