using Autofac;
using Employees.Repo;

namespace Employees.DI
{
    public class DependencyResolver
    {
        private static DependencyResolver _instance;

        public DependencyResolver Instance
        {
            get
            {
                return _instance ?? (_instance = new DependencyResolver());
            }
        }

        private IContainer _container;
        
        private DependencyResolver()
        {
            ConfigureContainer();
        }

        private void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();

            _container = builder.Build();            
        }

        public T Resolve<T>() => _container.Resolve<T>();
    }
}