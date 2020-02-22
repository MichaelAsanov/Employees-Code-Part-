namespace Employees.Models
{
    public class Employee
    {
        public int UserID { get; set; }
        
        public int ManagerId { get; set; }
        
        public string FIO { get; set; }
        
        public Department UserDepartment { get; set; }
    }
}