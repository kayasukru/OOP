public class Employee
{
    public int? EmployeeID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public override string ToString()
    {
        return $"{EmployeeID, -5} {FirstName, -15} {LastName, -15}";
    }
}
