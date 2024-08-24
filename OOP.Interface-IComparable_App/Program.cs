using OOP.Interface_IComparable_App;

internal class Program
{
    private static void Main(string[] args)
    {
        var employees = new List<Employee>()
        {
            new Employee()
            {
                Id=1,
                FullName= "Şükrü Kaya",
                Salary=2500.00M
            },
            new Employee()
            {
                Id=2,
                FullName= "Betül Sena Kaya",
                Salary=5500.00M
            },
            new Employee()
            {
                Id=3,
                FullName= "Bilge Seva Kaya",
                Salary=6700.00M
            },
            new Employee()
            {
                Id=4,
                FullName= "Selma Kaya",
                Salary=8700.00M
            },
            new Employee()
            {
                Id=5,
                FullName= "Ali Kaya",
                Salary=9800.00M
            },
            new Employee()
            {
                Id=6,
                FullName= "Güler Kaya",
                Salary=2500.00M
            }
        };

        //CompareTo() metoduna göre Salary'ye göre artan şekilde sıralar
        employees.Sort();

        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine();
    }
}