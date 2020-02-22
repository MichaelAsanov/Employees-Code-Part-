using System.Linq;
using Employees.DI;
using NUnit.Framework;

namespace Employees.Repo.Tests
{
    public class EmployeesRepositoryTests
    {
        [Test]
        public void GetListTest()
        {
            var repo = DependencyResolver.Instance.Resolve<IEmployeeRepository>();

            var employees = repo.GetList();
            
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Any());
            Assert.AreEqual(6, employees.Count());
        }
    }
}