using Employees.DI;
using NUnit.Framework;

namespace Employees.Repo.Tests
{
    public class DepartmentRepositoryTests
    {
        [Test]
        public void GetByNameTest1()
        {
            var repo = DependencyResolver.Instance.Resolve<IDepartmentRepository>();

            var department = repo.GetByName("IT");
            
            Assert.IsNotNull(department);
            Assert.AreEqual("IT", department.DepName);
        }
        
        [Test]
        public void GetByNameTest2()
        {
            var repo = DependencyResolver.Instance.Resolve<IDepartmentRepository>();

            var department = repo.GetByName("Бухгалтерия");
            
            Assert.IsNotNull(department);
            Assert.AreEqual("Бухгалтерия", department.DepName);
        }
    }
}