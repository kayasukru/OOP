using System.Data;
using System.Data.SqlClient;
internal partial class Program
{

    private static void Main(string[] args)
    {
        // Create();

        Read();

        // Update();

        // Delete();


    }

    // Delete Method
    private static void Delete()
    {
        // Delete
        var employee = new Employee()
        {
            EmployeeID = 15,
        };

        //ADONET
        //Command
        var cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @employeeId");
        cmd.Parameters.AddWithValue("employeeId", employee.EmployeeID);

        var s = RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır

        if (s > 0)
        {
            Console.WriteLine(employee.EmployeeID + " ID'li Kayıt Silindi : " + s);
        }
    }

    // Update Method
    private static void Update()
    {
        // Update
        var employee = new Employee()
        {
            EmployeeID = 11,
            FirstName = "Nurcan",
            LastName = "Boz",
        };

        //ADONET
        //Command
        var cmd = new SqlCommand("UPDATE Employees SET FirstName = @firstName, LastName = @lastName WHERE EmployeeID = @employeeId");
        cmd.Parameters.AddWithValue("firstName", employee.FirstName);
        cmd.Parameters.AddWithValue("lastName", employee.LastName);
        cmd.Parameters.AddWithValue("employeeId", employee.EmployeeID);

        var s = RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır

        if (s > 0)
        {
            Console.WriteLine(employee.EmployeeID + " ID'li Kayıt Güncellendi : " + s);
        }
    }

    // Read Method
    private static void Read()
    {
        var _list = new List<Employee>();
        var cmd = new SqlCommand("SELECT EmployeeID, FirstName, LastName FROM Employees");
        var ds = RDMS.SqlReader(cmd);

        foreach (DataRow item in ds.Tables[0].Rows)
        {
            _list.Add(new Employee()
            {
                EmployeeID = int.Parse(item[0].ToString()), // [0] ifadesi sorgudaki EmployeeID'nin sırasıdır
                FirstName = item[1].ToString(), // [1] ifadesi sorgudaki FirstName'nin sırasıdır
                LastName = item[2].ToString() // [1] ifadesi sorgudaki LastName'nin sırasıdır
            });
        }

        //lambda ve ForEach() methodu ile listeleme
        Console.WriteLine("Employee Listesi");
        _list.ForEach(e => Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName));
        Console.WriteLine();

        //VEYA
        //Employee sınıfı içinde ToString() metodunda çıktı biçimlendirilebilir
        Console.WriteLine("Employees Listesi");
        Console.WriteLine($"{"ID",-5} {"First Name",-15} {"Last Name",-15}");
        Console.WriteLine("--    ----------      ---------");

        _list.ForEach(e => Console.WriteLine(e));
    }

    // Create Method
    private static void Create()
    {
        var employee = new Employee()
        {
            FirstName = "Hatice",
            LastName = "Yalçın",
        };

        //Command
        var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@firstName, @lastName)");
        cmd.Parameters.AddWithValue("firstName", employee.FirstName);
        cmd.Parameters.AddWithValue("lastName", employee.LastName);

        var s = RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır

        if (s > 0)
        {
            Console.WriteLine("Kayıt Tamamlandı : " + s);
        }
    }
}