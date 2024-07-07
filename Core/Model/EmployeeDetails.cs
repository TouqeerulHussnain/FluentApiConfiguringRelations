namespace FluentApiConfiguringRelations.Core.Model
{
    public class EmployeeDetails
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
