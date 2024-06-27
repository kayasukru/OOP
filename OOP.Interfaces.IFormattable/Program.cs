using OOP.Interfaces.IFormattables;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine(DateTime.Now.ToString("d"));

        //var employee1 = new Employee
        //{
        //    Id = 1,
        //    Title = "Prof. Dr.",
        //    FirstName = "Şükrü",
        //    LastName = "Kaya"
        //};

        //Console.WriteLine(employee1);

        var list = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Title="Öğr.Gör",
                FirstName="Şükrü",
                LastName="Kaya"
            },
            new Employee()
            {
                Id = 2,
                Title="Doç.Dr.",
                FirstName="Şükrü",
                LastName="Baştürk"
            },
            new Employee()
            {
                Id = 3,
                Title="Prof.Dr.",
                FirstName="Erol",
                LastName="Ogur"
            },
            new Employee()
            {
                Id = 4,
                Title="Prof.Dr.",
                FirstName="Recep",
                LastName="Çıbık"
            },
            new Employee()
            {
                Id = 5,
                Title="Prof.Dr.",
                FirstName="Mustafa",
                LastName="Tayar"
            },
        };

        // tanımladığımız formatlara göre çıktılar
        Console.WriteLine("Varsayılan (F) formattaki liste:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine();

        Console.WriteLine("F (varsayılan) formatına göre liste:");
        foreach (var item in list)
        {
            Console.WriteLine(item.ToString("F"));
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine();

        Console.WriteLine("FL formatına göre liste:");
        foreach (var item in list)
        {
            Console.WriteLine(item.ToString("FL"));
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine();

        Console.WriteLine("LF formatına göre liste:");
        foreach (var item in list)
        {
            Console.WriteLine(item.ToString("LF"));
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine();

        Console.WriteLine("S formatına göre liste:");
        foreach (var item in list)
        {
            Console.WriteLine(item.ToString("S"));
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine();

        Console.WriteLine("SS formatına göre liste:");
        foreach (var item in list)
        {
            Console.WriteLine(item.ToString("SS"));
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine();

    }
}