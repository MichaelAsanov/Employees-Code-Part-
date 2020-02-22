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
                    ManagerId = 2,
                    FIO = "Михаил",
                    UserDepartment = _departmentRepository.GetByName("IT"),
                    UserID = 1
                },
                new Employee()
                {
                    ManagerId = 3,
                    FIO = "Александр",
                    UserDepartment = _departmentRepository.GetByName("IT"),
                    UserID = 2
                },
                new Employee()
                {
                    ManagerId = 7,
                    FIO = "Максим",
                    UserDepartment = _departmentRepository.GetByName("IT"),
                    UserID = 3
                },
                new Employee()
                {
                    ManagerId = 7,
                    FIO = "Максим",
                    UserDepartment = _departmentRepository.GetByName("IT"),
                    UserID = 3
                },
                new Employee()
                {
                    ManagerId = 5,
                    FIO = "Ирина",
                    UserDepartment = _departmentRepository.GetByName("Бухгалтерия"),
                    UserID = 4
                },
                new Employee()
                {
                    ManagerId = 6,
                    FIO = "Светлана",
                    UserDepartment = _departmentRepository.GetByName("Бухгалтерия"),
                    UserID = 5
                },
                new Employee()
                {
                    ManagerId = 7,
                    FIO = "Екатерина",
                    UserDepartment = _departmentRepository.GetByName("Бухгалтерия"),
                    UserID = 6
                }
            };
        }

        public IEnumerable<Employee> GetList() => _employees;

        public Employee GetByID(int id) => _employees.FirstOrDefault(x => x.UserID == id);
    }
}