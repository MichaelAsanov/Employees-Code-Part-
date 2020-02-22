using Employees.Models;

namespace Employees.Repo
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department GetByName(string name);
    }
}