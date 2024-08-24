using OOP.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {

        var saver = new SaverAccount();

        saver.PayIn(500);
        saver.Withdraw(300);
        saver.Withdraw(500);
        Console.WriteLine("Bakiye : " + saver.Balance);
        Console.WriteLine(saver);


    }
}
