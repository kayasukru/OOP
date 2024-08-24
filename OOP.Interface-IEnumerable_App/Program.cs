using OOP.Interface_IEnumerable_App;

internal class Program
{
    private static void Main(string[] args)
    {
        // klasik dizi foreach ile ekrana yazdırılabilir
        var arr = new int[] { 2, 4, 6, 8 };

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("--------------------------");

        //customArr IEnumerable olarak tanımlnmazsa foreach ile yazdırılamaz.
        var customArr = new Dizi(1, 3, 5, 7);
        foreach (var ii in customArr)
        {
            Console.WriteLine(ii);
        }
    }
}