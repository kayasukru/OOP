using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        //ADONET
        //Connection
        string connectionString = @"Data Source=SKYN\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True;Connect Timeout=30;";

        // 1. Yöntem
        var conn = new SqlConnection(connectionString);

        // 2. yöntem
        //conn.ConnectionString = connectionString;

        conn.Open();


        //Command
        var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@firstName, @lastName)");
        cmd.Parameters.AddWithValue("@firstName", "Şakir");
        cmd.Parameters.AddWithValue("@lastName", "Dağcı");

        cmd.Connection = conn; //bağlantı stringi bildirimi

        var s = cmd.ExecuteNonQuery(); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır

        if (s > 0)
        {
            Console.WriteLine("Kayıt Tamamlandı : " + s);
        }

    }
}