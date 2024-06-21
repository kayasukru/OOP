internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-------- Standart Sınıf Yapısı ile kullanım ---------");
        // standart sınıf yapısı ile kullanım
        Employee employee = new Employee();
        employee.FirstName = "Şükrü";
        employee.LastName = "Kaya";
        employee.Age = 57;
        Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Age);
        Console.WriteLine();
    }
}