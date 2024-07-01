using System.Data.SqlClient;
internal class Program
{
    private static void Main(string[] args)
    {
        // Create();


        // Read

        var _list = new List<Employee>();

        // connection
        string connectionString = @"Data Source=SKYN\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True;";
        var conn = new SqlConnection(connectionString);
        conn.Open();

        //Command
        var cmd = new SqlCommand("SELECT EmployeeID, FirstName, LastName FROM Employees", conn); 

        // Data Reader
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            _list.Add(new Employee()
            {
                EmployeeID = int.Parse(reader[0].ToString()), // [0] ifadesi sorgudaki EmployeeID'nin sırasıdır
                FirstName = reader[1].ToString(), // [1] ifadesi sorgudaki FirstName'nin sırasıdır
                LastName = reader[2].ToString() // [1] ifadesi sorgudaki LastName'nin sırasıdır
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
            FirstName = "Selmahan",
            LastName = "Görgel",
        };

        //ADONET
        //Connection
        string connectionString = @"Data Source=SKYN\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True;";

        // 1. Bağlantı Yöntemi
        //var conn = new SqlConnection(connectionString);

        // 2. Bağlantı Yöntemi
        //conn.ConnectionString = connectionString;

        // refactoring işlemi ile bellek kullanımını iyileştirdik
        using (var conn = new SqlConnection(connectionString))
        {

            try
            {
                conn.Open();

                //Command
                var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@firstName, @lastName)");
                cmd.Parameters.AddWithValue("firstName", employee.FirstName);
                cmd.Parameters.AddWithValue("lastName", employee.LastName);

                cmd.Connection = conn; //bağlantı stringi bildirimi

                var s = cmd.ExecuteNonQuery(); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır

                if (s > 0)
                {
                    Console.WriteLine("Kayıt Tamamlandı : " + s);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}