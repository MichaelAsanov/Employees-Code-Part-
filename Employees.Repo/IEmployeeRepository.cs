using System.Collections.Generic;
using Employees.Models;

namespace Employees.Repo
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetList();
        
         Employee GetByID(int id);
    }
}