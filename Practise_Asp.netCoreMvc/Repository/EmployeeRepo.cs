using Practise_Asp.netCoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Asp.netCoreMvc.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private List<Employee> _employee;
        public EmployeeRepo()
        {
            _employee = new List<Employee>()
            {
                new Employee(){ID=1,Name="saif",Department="IT",Email="saifmhr@gmail.com"},
                new Employee(){ID=2,Name="Sajjad",Department="HR",Email="sajjadlaghari@gmail.com"},
                new Employee(){ID=3,Name="tariq",Department="IT",Email="tariqodho@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.ID = _employee.Max(e => e.ID) + 1;
            _employee.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employee;
        
        }

      
        public Employee GetEmployee(int ID)
        {
            return _employee.FirstOrDefault(e => e.ID == ID);
        }
    }
}
