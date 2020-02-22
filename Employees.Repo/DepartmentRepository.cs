using System.Collections.Generic;
using System.Linq;
using Employees.Models;

namespace Employees.Repo
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IEnumerable<Department> _departments;

        public DepartmentRepository()
        {
            _departments = new List<Department>()
            {
                new Department()
                {
                    DepId = 1,
                    DepName = "IT"
                },
                new Department()
                {
                    DepId = 2,
                    DepName = "Бухгалтерия"
                }
            };
        }

        public Department GetByName(string name)
        {
            return _departments.FirstOrDefault(x => x.DepName == name);
        }
    }
}