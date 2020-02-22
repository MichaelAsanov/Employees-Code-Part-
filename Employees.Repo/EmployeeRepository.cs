using System;
using System.Collections.Generic;
using System.Linq;
using Employees.Models;

namespace Employees.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEnumerable<Employee> _employees;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeRepository(IDepartmentRepository departmentRepository)
        {
            _departmentRepository =
                departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
            
            _employees = new List<Employee>()
            {
                new Employee()
                {
                    UserID = 1,
                    FIO = "Михаил",
                    UserDepartment = _departmentRepository.GetByName("IT"),
                    ManagerId = 2,
                },
                new Employee()
                {
                    UserID = 2,
                    FIO = "Александр",
                    UserDepartment = _departmentRepository.GetByName("IT"),
                    ManagerId = 3,
                },
                new Employee()
                {
                    UserID = 3,                    
                    FIO = "Максим",
                    UserDepartment = _departmentRepository.GetByName("IT"),
                    ManagerId = 7,
                },
                new Employee()
                {
                    UserID = 4,
                    FIO = "Ирина",
                    UserDepartment = _departmentRepository.GetByName("Бухгалтерия"),
                    ManagerId = 5,
                },
                new Employee()
                {
                    UserID = 5,                    
                    FIO = "Светлана",
                    UserDepartment = _departmentRepository.GetByName("Бухгалтерия"),
                    ManagerId = 6,
                },
                new Employee()
                {
                    UserID = 6,
                    FIO = "Екатерина",
                    UserDepartment = _departmentRepository.GetByName("Бухгалтерия"),
                    ManagerId = 7,
                }
            };
        }

        public IEnumerable<Employee> GetList() => _employees;

        public Employee GetByID(int id) => _employees.FirstOrDefault(x => x.UserID == id);
    }
}