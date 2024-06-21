using OOP.AddAClass;

internal class Program
{
    private static void Main(string[] args)
    {
        // standart sınıf yapısı ile kullanım
        StandartSinifMetoduKullanimi();

        // Constructor ile kullanım
        ConstructorKullanimi();

        // Override (Employee sınıfında override işleminden sonra field ya da propperty yazmaya gerek yoktur.
        ToStringIleCiktiBicimlendirme();

        // Dizi yapıları ile çıktı alma. Biçimlendirme Employee sınıfında ToString() metodu ile yapıldı.
        DiziCiktilari();

    }

    // Dizi çıktıları
    private static void DiziCiktilari()
    {
        Console.WriteLine("-------- Dizi yapıları ile çıktı alma ---------");
        Employee employee = new Employee();
        employee.FirstName = "Şükrü";
        employee.LastName = "Kaya";
        employee.Age = 57;

        Employee employee2 = new Employee("Bilge Seva", "Kaya", 23);

        Employee employee3 = new Employee("Betül Sena", "Kaya", 25);

        Employee employee4 = new Employee()
        {
            FirstName = "Selma",
            LastName = "Kaya",
            Age = 58
        };

        // Dizi Çıktısı
        var list = new List<Employee>();

        list.Add(employee);
        list.Add(employee2);
        list.Add(employee3);
        list.Add(employee4);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();


        // Dizi2 çıktısı
        Console.WriteLine("-------- Dizi2 Çıktısı -------------");
        var list2 = new List<Employee>()
        {
            new Employee(){ FirstName = "Hasibe", LastName = "Kaya", Age = 82},
            new Employee(){ FirstName = "Nesibe", LastName = "Kaya", Age = 62},
            new Employee(){ FirstName = "Ali", LastName = "Kaya", Age = 64},
            new Employee(){ FirstName = "Aynur", LastName = "Kaya", Age = 50}
        };

        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    // Override (Employee sınıfında override işleminden sonra field ya da propperty yazmaya gerek yoktur.
    private static void ToStringIleCiktiBicimlendirme()
    {
        Console.WriteLine("-------- ToString() ile Override ile kullanım ---------");
        Employee employee3 = new Employee("Betül Sena", "Kaya", 25);
        Console.WriteLine(employee3);
        Console.WriteLine();
    }

    // Constructor ile kullanım
    private static void ConstructorKullanimi()
    {
        Console.WriteLine("-------- Constructor ile kullanım ---------");
        Employee employee2 = new Employee("Bilge Seva", "Kaya", 23);
        Console.WriteLine($"{employee2.FirstName} {employee2.LastName} {employee2.Age}");
    }

    // standart sınıf yapısı ile kullanım
    private static void StandartSinifMetoduKullanimi()
    {
        Console.WriteLine("-------- Standart Sınıf Yapısı ile kullanım ---------");
        Employee employee = new Employee();
        employee.FirstName = "Şükrü";
        employee.LastName = "Kaya";
        employee.Age = 57;
        Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Age);
        Console.WriteLine();
    }
}