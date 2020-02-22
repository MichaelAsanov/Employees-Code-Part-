using System;
using Employees.DI;
using Employees.Repo;

namespace Employees.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = DependencyResolver.Instance.Resolve<IEmployeeRepository>();

            var employees = repo.GetList();

            foreach (var employee in employees)
            {
                System.Console.WriteLine($"{employee?.UserDepartment?.DepName} - {employee?.FIO} - {repo.GetByID(employee.ManagerId)?.FIO}");
            }
            
            System.Console.ReadKey();
        }
    }
}