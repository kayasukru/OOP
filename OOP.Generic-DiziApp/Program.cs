internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Generic Class");
        Console.WriteLine();
        Console.WriteLine("Generic Class int dizisi");
        var dizi1 = new Dizi<byte>(1, 3, 5, 7, 9, 11, 13, 15);

        foreach (var item in dizi1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("Generic Class string dizisi");
        var dizi2 = new Dizi<string>("Ali", "Veli", "Selami");

        foreach (var item in dizi2)
        {
            Console.WriteLine(item);
        }
    }
}