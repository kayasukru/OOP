using OOP.AddAClass;

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


        Console.WriteLine("-------- Constructor ile kullanım ---------");
        // Constructor ile kullanım
        Employee employee2 = new Employee("Bilge Seva", "Kaya", 23);
        Console.WriteLine($"{employee2.FirstName} {employee2.LastName} {employee2.Age}");

        // Override (Employee sınıfında override işleminden sonra field ya da propperty yazmaya gerek yoktur.
        Employee employee3 = new Employee("Betül Sena", "Kaya", 25);
        Console.WriteLine(employee3);
    }
}