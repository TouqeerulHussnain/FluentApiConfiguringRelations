namespace FluentApiConfiguringRelations.Core.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EmployeeDetails EmployeeDetails { get; set; }
        public Guid? ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}
