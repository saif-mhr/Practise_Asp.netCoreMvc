using Practise_Asp.netCoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Asp.netCoreMvc.Repository
{
  public  interface IEmployeeRepo
    {
        Employee GetEmployee(int ID);
        IEnumerable<Employee> GetAllEmployee();

        Employee Add(Employee employee);
    }
}
